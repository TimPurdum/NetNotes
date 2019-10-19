using System.Collections.Generic;

namespace NoteSystem.Business.Elements
{
    public class Score
    {
        public Score() { }

        public Score(IList<Staff> staves)
        {
            Staves = staves;
        }

        public IList<Staff> Staves { get; set; }

        public string Title { get; set; }
        public string Composer { get; set; }
        public string Lyricist { get; set; }
    }
}
