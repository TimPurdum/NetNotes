using NetNotes.Business.Elements.Interfaces;

namespace NetNotes.Business.Elements
{
    public struct DynamicLevelExpression : IExpression
    {
        internal DynamicLevelExpression(string symbol, string name, ExpressionPosition position = ExpressionPosition.Below)
        {
            Symbol = symbol;
            Name = name;
            Position = position;
        }

        public ExpressionPosition Position { get; set; }
        public string Symbol { get; }
        public string Name { get; }
    }

    public static class DynamicLevels
    {
        public static DynamicLevelExpression Pianississimo => new DynamicLevelExpression("ppp", "Pianississimo");
        public static DynamicLevelExpression Pianissimo => new DynamicLevelExpression("pp", "Pianissimo");
        public static DynamicLevelExpression Piano => new DynamicLevelExpression("p", "Piano");
        public static DynamicLevelExpression MezzoPiano => new DynamicLevelExpression("mp", "Mezzo Piano");
        public static DynamicLevelExpression MezzoForte => new DynamicLevelExpression("mf", "Mezzo Forte");
        public static DynamicLevelExpression Forte => new DynamicLevelExpression("f", "Forte");
        public static DynamicLevelExpression Fortissimo => new DynamicLevelExpression("ff", "Fortissimo");
        public static DynamicLevelExpression Fortississimo => new DynamicLevelExpression("fff", "Fortississimo");
    }
}
