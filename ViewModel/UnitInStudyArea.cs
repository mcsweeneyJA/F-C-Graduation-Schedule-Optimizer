namespace QUT
{
    public class UnitInStudyArea
    {
        public string code { get; set; } // e.g. CAB402
        public int XPos { get; set; } // where to position this unit within study area canvas
        public int YPos { get; set; }
        public string studyArea { get; set; } // code of the study area that this unit belongs to
        public string statusColour { get; set; } // colour indicating whether this unit is currently enrolled, enrollable or un-enrollable
        public string offering { get; set; } // which semesters is this unit offered, e.g. semester 1 or 2
        public string group { get; set; } // which group of units does this unit belong to within this study area, e.g. Core or Option
    }
}
