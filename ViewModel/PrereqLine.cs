namespace QUT
{
    // a line to represent a prerequiste relationship between two units
    public class PrereqLine
    {
        // centre of source unit
        public int X1 { get; set; }
        public int Y1 { get; set; }
        // centre of destination unit
        public int X2 { get; set; }
        public int Y2 { get; set; }
    }
}