using System.Collections.Generic;

namespace NetNotes.Business.Elements
{
    public class Score
    {
        public Score() { }

        public Score(List<Staff> staves)
        {
            Staves = staves;
        }

        public List<Staff> Staves { get; set; } = new List<Staff>();

        public string Title { get; set; }
        public string Composer { get; set; }
        public string Lyricist { get; set; }
        public string Copyright { get; set; }
    }
}
