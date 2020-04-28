using System.Collections.Generic;
using System.Linq;

namespace QUT
{
    using StudyPlan = IEnumerable<UnitInPlan>;

    public class CSharpSchedulingWizard
    {
        public static Semester currentSemester
        {
            // Do not change
            get { return new Semester(2020, Offering.Semester1); }
        }

        public static IEnumerable<StudyPlan> TryToImproveSchedule(StudyPlan plan)
        {
            Semester firstSem = currentSemester;
            var lastSem = plan.GetEnumerator();
            
            
            
            yield break;
            
        }
    }
}