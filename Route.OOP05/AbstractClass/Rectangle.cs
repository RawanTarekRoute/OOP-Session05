namespace Route.OOP05.AbstractClass
{
    internal class Rectangle : Shape
    {
 
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public Rectangle(string color, decimal width, decimal height) : base(color)
        {
            Width = width;
            Height = height;
        }
        public override decimal CalcualteArea()
        {
            return Width * Height;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine("This is rectangle");
            base.DisplayInformation();
        }
    }
}
