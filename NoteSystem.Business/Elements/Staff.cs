using System.Collections.Generic;

namespace NoteSystem.Business.Elements
{
    public class Staff
    {
        public Staff() { }

        public Staff(IList<Measure> measures)
        {
            Measures = measures;
        }

        public IList<Measure> Measures { get; set; }
        public int Lines { get; set; } = 5;

        public string PartName { get; set; }
    }
}
