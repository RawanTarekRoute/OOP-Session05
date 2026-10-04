namespace Route.OOP05.AbstractClass
{
    internal abstract class Shape
    {
        public string Color { get; set; }

        protected Shape(string color)
        {
            // validation
            Color = color;
        }



        public abstract decimal CalcualteArea();

        public virtual void DisplayInformation()
        {
            Console.WriteLine($"{GetType().Name} Color: {Color}");
            Console.WriteLine(CalcualteArea());
        }

        public void DescribeShape()
        {
            Console.WriteLine($"I am a shape with color: {Color}");
        }



    }
}
