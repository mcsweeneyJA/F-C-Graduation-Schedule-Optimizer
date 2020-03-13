using System.Collections.Generic;
using System.Linq;
using ReactiveUI.Fody.Helpers;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Threading;
using ReactiveUI;
using System.Reactive;
using System.Diagnostics;
using DynamicData;

namespace QUT
{
    using StudyPlan = IEnumerable<UnitInPlan>;

    public class ViewModel : ReactiveObject
    {
        // the units currently in our study plan (mutable)
        public readonly SourceList<UnitInPlan> plan = new SourceList<UnitInPlan>();

        [Reactive]
        // the unit code of the unit that is currently in flight (drag and drop)
        private string inFlightUnitCode { get; set; }

        // the study area of the unit that is currently in flight
        private string inFlightStudyArea { get; set; }

        [Reactive]
        // a list of the study areas in the currrently selected course
        private IEnumerable<StudyArea> studyAreas { get; set; }


        // note new inflight unit from a study area
        private void PickUnit(UnitInStudyArea unit)
        {
            inFlightUnitCode = unit.code;
            inFlightStudyArea = unit.studyArea;
        }

        // if we try moving a unit from one semester to another, remember where it came from (in case the move is not legal)
        private Semester oldPosition = null;

        // note new inflight unit from the current study plan
        private void PickUnit(UnitInPlan unit)
        {
            oldPosition = unit.semester;
            plan.Remove(unit);
            inFlightUnitCode = unit.code;
            inFlightStudyArea = unit.studyArea;
        }

        // note that currently inflight unit has been dropped
        private void DropInFlight()
        {
            inFlightUnitCode = null;
            inFlightStudyArea = null;
            oldPosition = null;
        }

        // Can we legally drop the currently inFlight unit in the specified semester?
        private bool CanScheduleIn(Semester semester)
        {
            return inFlightUnitCode != null && StudyPlannerModel.isEnrollableIn(inFlightUnitCode, semester, plan.Items);
        }

        // Add the currently inFlight unit to the specified semester if it is legal to do so, otherwise return it to where it came from
        private void Schedule(Semester semester)
        {
            if (CanScheduleIn(semester))
                plan.Add(new UnitInPlan(inFlightUnitCode, inFlightStudyArea, semester));
            else if (oldPosition != null)
                plan.Add(new UnitInPlan(inFlightUnitCode, inFlightStudyArea, oldPosition)); // put it back where it used to be
        }

        private CancellationTokenSource cancelWizard;

        private Task Wizard(bool FSharpVersion)
        {
            cancelWizard = new CancellationTokenSource();

            // run the study plan wizard in the background on a separate thread (so that the UI remains responsive)
            return Task.Run(() =>
            {
                if (plan.Items.Count() > 0 && StudyPlannerModel.isLegalPlan(plan.Items))
                {
                    IEnumerable<StudyPlan> wizard;
                    if (FSharpVersion)
                        wizard = FSharpSchedulingWizard.TryToImproveSchedule(plan.Items);
                    else
                        wizard = CSharpSchedulingWizard.TryToImproveSchedule(plan.Items);

                    foreach (var betterPlan in wizard)
                    {
                        Debug.Assert(StudyPlannerModel.isLegalPlan(plan.Items));
                        uiFactory.StartNew(() =>
                            {
                                // present each progressively improved study plan as they are discovered
                                plan.Clear();
                                plan.AddRange(betterPlan);
                            }, cancelWizard.Token);
                    }
                }
            }, cancelWizard.Token);
        }

        // Miscellaneous getter methods ...

        public string getUnitTitle(string unitCode)
        {
            return StudyPlannerModel.getUnitTitle(unitCode);
        }

        public string getPrereq(string unitCode)
        {
            return StudyPlannerModel.getPrereq(unitCode);
        }

        private string getGroup(string unitCode, string studyAreaCode)
        {
            return studyAreas.First(studyArea => studyArea.code == studyAreaCode).units.First(unit => unit.code == unitCode).group;
        }

        private string StudyAreaColour(string studyAreaCode)
        {
            return studyAreas.First(studyArea => studyArea.code == studyAreaCode).colour;
        }

        // Where to position unit on the study area canvas ...
        private int ScaleX(double x)
        {
            return (int)(950 * (1 + x * 9) / 100);
        }

        private int ScaleY(double y)
        {
            return (int)(600 * (6 - y) * 15 / 100);
        }

        // Load a new course by parsing Study Area information from a CSV resourse file
        private IEnumerable<StudyArea> LoadCourse(string CVSFile)
        {
            var studyAreas = new List<StudyArea>();
            using (var file = new System.IO.StringReader(CVSFile))
            {
                while (true)
                {
                    var studyArea = new StudyArea();
                    studyArea.code = file.ReadLine();
                    if (studyArea.code == "" || studyArea.code == null)
                        break;
                    studyArea.title = file.ReadLine();
                    studyArea.colour = file.ReadLine();
                    var units = new List<UnitInStudyArea>();
                    studyArea.units = units;
                    studyAreas.Add(studyArea);
                    while (true)
                    {
                        var line = file.ReadLine();
                        if (line == null)
                            break;
                        var csv = line.Split(',');
                        if (csv.Length < 3)
                            break;
                        else
                            units.Add(new UnitInStudyArea { code = csv[0], studyArea = studyArea.code, XPos = ScaleX(double.Parse(csv[1])), YPos = ScaleY(double.Parse(csv[2])), offering = StudyPlannerModel.displayOffered(csv[0]), group = csv[3] });
                    }
                }
            }
            return studyAreas;
        }

        // Update the status colours of the units in the study plan(s)
        private IEnumerable<StudyArea> enrollable(IEnumerable<UnitInPlan> plan, IEnumerable<StudyArea> studyareas)
        {
            foreach (var area in studyAreas)
                foreach (var unit in area.units)
                {
                    if (plan.Any(unitInPlan => unitInPlan.code == unit.code)) // units that are already enrolled are shown using the colour of the study area
                        unit.statusColour = StudyAreaColour(plan.First(unitInPlan => unitInPlan.code == unit.code).studyArea);
                    else if (StudyPlannerModel.isEnrollable(unit.code, plan)) // units that can be enrolled are shown in green
                        unit.statusColour = "Lime";
                    else
                        unit.statusColour = "LightGray"; // units that cannot yet be enrolled are shown in gray
                }
            return new List<StudyArea>(studyAreas);
        }

        // Transform the study plan (a list of enrolled units) into a list of semesters, each with their own list of enrolled units
        private IEnumerable<SemesterPlan> projectPlan()
        {
            List<SemesterPlan> semesters = new List<SemesterPlan>();

            var thisYear = System.DateTime.Now.Year;
            for (int year = thisYear+5; year >= thisYear-4; year--)
            {
                foreach (var offering in new Offering[] { Offering.Semester2, Offering.Semester1 })
                {
                    Semester semester = new Semester(year, offering);
                    semesters.Add(new SemesterPlan
                    {
                        label = StudyPlannerModel.display(semester),
                        semester = semester,
                        enrollable = inFlightUnitCode != null && StudyPlannerModel.isEnrollableIn(inFlightUnitCode, semester, plan.Items),
                        units = plan.Items
                            .Where(unit => unit.semester.Equals(semester))
                            .Select(unit => new UnitInSemester
                            {
                                unit = unit,
                                offering = StudyPlannerModel.displayOffered(unit.code),
                                group = getGroup(unit.code, unit.studyArea),
                                statusColour = StudyPlannerModel.isLegalIn(unit.code, semester, plan.Items) ? StudyAreaColour(unit.studyArea) : "Red"
                            })
                    });
                }
            }
            return semesters;
        }

        // Derived properties
        private readonly ObservableAsPropertyHelper<IEnumerable<SemesterPlan>> _semesters;
        public IEnumerable<SemesterPlan> semesters => _semesters.Value;

        private readonly ObservableAsPropertyHelper<IEnumerable<StudyArea>> _enrollableStudyAreas;
        public IEnumerable<StudyArea> enrollableStudyAreas => _enrollableStudyAreas.Value;

        private readonly ObservableAsPropertyHelper<IChangeSet<UnitInPlan>> _planChange;
        public IChangeSet<UnitInPlan> planChange => _planChange.Value;

        // Commands explosed by the ViewModel
        public ReactiveCommand<UnitInStudyArea, Unit> PickUnitFromStudyArea { get; private set; }
        public ReactiveCommand<UnitInPlan, Unit> PickUnitFromStudyPlan { get; private set; }
        public ReactiveCommand<Unit, Unit> DropInflight { get; private set; }
        public ReactiveCommand<Unit, Unit> SwitchToEN01 { get; private set; }
        public ReactiveCommand<Unit, Unit> SwitchToIN01 { get; private set; }
        public ReactiveCommand<Semester, Unit> ScheduleUnit { get; private set; }
        public ReactiveCommand<bool, Unit> ApplyWizard { get; private set; }
        public ReactiveCommand<Unit, Unit> CancelWizard { get; private set; }

        TaskFactory uiFactory;

        public ViewModel()
        {
            // allow bound property updates to happen on the UI thread
            uiFactory = new TaskFactory(TaskScheduler.FromCurrentSynchronizationContext());

            studyAreas = new List<StudyArea>();

            PickUnitFromStudyArea = ReactiveCommand.Create<UnitInStudyArea>(unit => PickUnit(unit));
            PickUnitFromStudyPlan = ReactiveCommand.Create<UnitInPlan>(unit => PickUnit(unit));

            DropInflight = ReactiveCommand.Create(() => DropInFlight());
            
            ScheduleUnit = ReactiveCommand.Create<Semester>(semester => Schedule(semester));
            
            ApplyWizard = ReactiveCommand.CreateFromTask<bool>(Wizard);
            CancelWizard = ReactiveCommand.Create(() => cancelWizard.Cancel());
            
            SwitchToEN01 = ReactiveCommand.Create(() => { studyAreas = LoadCourse(CourseData.Properties.Resources.EN01); plan.Clear();  });
            SwitchToIN01 = ReactiveCommand.Create(() => { studyAreas = LoadCourse(CourseData.Properties.Resources.IN01); plan.Clear();  });

            plan.Connect().ToProperty(this, vm => vm.planChange, out _planChange);

            // Update study area (unit colour coding) when plan or course changes
            this.WhenAnyValue(vm => vm.planChange, vm => vm.studyAreas)
                .Select(change => enrollable(plan.Items, studyAreas))
                .ToProperty(this, vm => vm.enrollableStudyAreas, out _enrollableStudyAreas);

            // Update study plan (by semester) when unit picked up or study plan changes
            this.WhenAnyValue(vm => vm.inFlightUnitCode, vm => vm.planChange)
                .Select(pair => projectPlan())
                .ToProperty(this, vm => vm.semesters, out _semesters);
        }
    }
}