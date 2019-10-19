using System.Collections.Generic;

namespace NetNotes.Business.Elements.Interfaces
{
    public interface IRhythmUnit
    {
        Duration Duration { get; }
        IList<IExpression> Expressions { get; }
    }
}
