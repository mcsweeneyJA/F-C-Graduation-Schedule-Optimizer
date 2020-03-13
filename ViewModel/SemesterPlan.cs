using System.Collections.Generic;

namespace QUT
{ 
    // Represents a particular semester of the study plan
    public class SemesterPlan
    {
        public string label { get; set; } // the semester label as a string, e.g. 2019/2
        public Semester semester { get; set; }
        public bool enrollable { get; set; } // true iff the currently inFlight unit can be placed in this semester
        public IEnumerable<UnitInSemester> units { get; set; } // the units in the study plan that are taken in this semester
    }
}
