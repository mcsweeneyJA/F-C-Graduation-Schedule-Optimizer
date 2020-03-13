namespace QUT
{
    public class UnitInSemester
    {
        public UnitInPlan unit { get; set; } // details of a unit currently in the study plan
        public string statusColour { get; set; } // display Red warning colour if this unit is not legal in this semester of the study plan
        public string offering { get; set; } // which semesters is this unit offered, e.g. semester 1 or 2
        public string group { get; set; } // which group of units does this unit belong to within this study area, e.g. Core or Option
    }
}
