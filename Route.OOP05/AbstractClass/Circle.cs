namespace Route.OOP05.AbstractClass
{
    internal class Circle : Shape
    {
        // private backing field
        public decimal Raidus { get; set;}

        public Circle(string color, decimal radius) : base(color)
        {
            Raidus = radius;
        }

        public override decimal CalcualteArea()
        {
            return (decimal)Math.PI * Raidus * Raidus;
        }
    }
}
