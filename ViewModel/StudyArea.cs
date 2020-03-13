using System.Collections.Generic;
using System.Linq;

namespace QUT
{
    public class StudyArea
    {
        public string code; // code of the study area, e.g. IN01MJR-COMPSC
        public string title { get; set; } // title of study area, e.g. "Computer Science Major"
        public string colour { get; set; } // colour code used for this study area
        public IEnumerable<UnitInStudyArea> units { get; set; } // the units that make up this study area

        public IEnumerable<PrereqLine> prereqs
        {
            // create lines representing all prerequisiste relations between units in this study area
            get
            {
                foreach (var unit in units)
                {
                    foreach (var prereqCode in StudyPlannerModel.UnitPrereqs(unit.code))
                    {
                        // find the other unit if it is part of this study area
                        var prereqUnit = units.FirstOrDefault(u => u.code == prereqCode);
                        if (prereqUnit != null)
                            yield return new PrereqLine { X1 = unit.XPos + 38, Y1 = unit.YPos + 25, X2 = prereqUnit.XPos + 38, Y2 = prereqUnit.YPos + 25 };
                    }
                }
            }
        }
    }
}
