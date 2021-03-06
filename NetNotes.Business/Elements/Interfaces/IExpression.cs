﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetNotes.Business.Elements.Interfaces
{
    public interface IExpression
    {
        ExpressionPosition Position { get; set; }
    }

    public enum ExpressionPosition
    {
        Above,
        Below
    }
}
