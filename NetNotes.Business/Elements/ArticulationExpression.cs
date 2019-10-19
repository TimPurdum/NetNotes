using NetNotes.Business.Elements.Interfaces;

namespace NetNotes.Business.Elements
{
    public struct ArticulationExpression: IExpression
    {
        internal ArticulationExpression(string name, ExpressionPosition position = ExpressionPosition.Below)
        {
            Name = name;
            Position = position;
        }

        public ExpressionPosition Position { get; set; }
        public string Name { get; }
    }

    public static class Articulations
    {
        public static ArticulationExpression Staccato => new ArticulationExpression("Staccato");
        public static ArticulationExpression Marcato => new ArticulationExpression("Marcato");
        public static ArticulationExpression Spiccato => new ArticulationExpression("Spiccato");
        public static ArticulationExpression Accent => new ArticulationExpression("Accent");
        public static ArticulationExpression Tenuto => new ArticulationExpression("Tenuto");
        public static ArticulationExpression Fermata => new ArticulationExpression("Fermata");
    }
}