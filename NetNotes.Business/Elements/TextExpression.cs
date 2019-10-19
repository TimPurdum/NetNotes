using NetNotes.Business.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetNotes.Business.Elements
{
    public class TextExpression : IExpression
    {
        public TextExpression(string text, ExpressionPosition position = ExpressionPosition.Above)
        {
            Text = text;
            Position = position;
        }

        public string Text { get; set; }

        public ExpressionPosition Position { get; set; }
    }
}
