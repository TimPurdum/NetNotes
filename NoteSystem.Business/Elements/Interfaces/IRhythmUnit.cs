using System.Collections.Generic;

namespace NoteSystem.Business.Elements.Interfaces
{
    public interface IRhythmUnit
    {
        Duration Duration { get; }
        IList<IExpression> Expressions { get; }
    }
}
