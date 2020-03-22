using System.Collections.Generic;

namespace NetNotes.Business.Elements
{
    public class Staff
    {
        public Staff() { }

        public Staff(List<Measure> measures)
        {
            Measures = measures;
        }

        public List<Measure> Measures { get; set; } = new List<Measure>();
        public int Lines { get; set; } = 5;

        public string PartName { get; set; }

        public string AbbreviatedName { get; set; }
    }
}
