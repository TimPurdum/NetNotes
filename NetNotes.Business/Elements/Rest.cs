using NetNotes.Business.Elements.Interfaces;
using System.Collections.Generic;

namespace NetNotes.Business.Elements
{
    public class Rest : IRhythmUnit
    {
        public Rest(string restString)
        {
            var invariant = restString.ToUpperInvariant();
            if (invariant.EndsWith("REST"))
            {
                invariant = invariant.Replace("REST", "");
            }
            else if (!invariant.EndsWith("QUARTER") &&
                invariant.EndsWith("R"))
            {
                invariant = invariant.Trim('R');
            }
            Duration = new Duration(invariant);
        }

        public Duration Duration { get; set; }
        public IList<IExpression> Expressions { get; set; }
    }
}
