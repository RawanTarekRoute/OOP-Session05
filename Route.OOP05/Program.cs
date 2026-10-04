using Route.OOP05.AbstractClass;
using Route.OOP05.ObjectCopying;

namespace Route.OOP05
{
   
    internal class Program
    {
        public static void TestShapes(Shape shape)
        {
            Console.WriteLine(shape.CalcualteArea());
        }

        static void Main(string[] args)
        {
            #region Abstract Class
           
            //Shape shape = new Shape();

            //Circle circle = new Circle("red", 12);
            //circle.DescribeShape();
            //Console.WriteLine(circle.CalcualteArea());
            //circle.DisplayInformation();


            //Shape[] shapes =
            //{
            //    new Rectangle("red", 10, 10),
            //    new Circle("black", 10)
            //};

            //foreach (Shape shape in shapes)
            //{
            //    TestShapes(shape);
            //}

            #endregion

            #region Shallow Copy

            /*
             * Value types => the actual value is copied, variables are independent.
             * Reference types => only the reference is copied, both variables point to the same object.
             * Assignment (=) does not create a new object, it creates a new reference to the same object [Same Identity].
             *
             * Shallow Copy:
             *      - Creates a new object and copies the top-level fields.
             *      - Value type fields => actual values are copied.
             *      - Reference type fields (Address, Phones) => only references are copied, nested objects are shared.
             *      - Created using MemberwiseClone() (protected method in System.Object) or by implementing ICloneable.
             *      - Faster than deep copy.
             */

            #region Ex01 - Value Types

            //int x = 10;
            //int y = x;

            //Console.WriteLine($"X={x}");
            //Console.WriteLine($"y={y}");

            //y = 20;
            //Console.WriteLine("After Change");

            //Console.WriteLine($"X={x}");
            //Console.WriteLine($"y={y}");

            #endregion

            #region Ex02 - Reference Assignment using = operator

            //Person original = new Person(20, "Ali", new Address("Giza"));
            //Person copy = original;

            //Console.WriteLine(ReferenceEquals(original, copy));
            //Console.WriteLine($"{original.GetHashCode()} :: {copy.GetHashCode()}");

            //copy.Age = 23;
            //// original will be affected? yes
            //// copy? yes

            //Console.WriteLine($"{original.Age} :: {copy.Age}");



            #endregion

            #region Ex03 - Shallow Copy using MemberwiseClone

            //Person original = new Person(20, "Ali", new Address("Giza"));
            ////Person copy = original.MemberwiseClone();

            //Person copy = original.ShallowCopy();

            //// false
            //Console.WriteLine(ReferenceEquals(original, copy));


            //Console.WriteLine(ReferenceEquals(original.HomeAddress, copy.HomeAddress));
            //Console.WriteLine($"{original.HomeAddress.GetHashCode()} :: {copy.HomeAddress.GetHashCode()}");
            //Console.WriteLine($"{original.GetHashCode()} :: {copy.GetHashCode()}");

            //copy.Age = 23;
            //Console.WriteLine($"{original.Age} :: {copy.Age}");

            //original.HomeAddress.City = "Cairo";
            //// 
            //Console.WriteLine($"{original.HomeAddress.City} :: {copy.HomeAddress.City}");



            #endregion

            #region Ex04 - Shallow Copy using ICloneable

            //Person original = new Person(20, "Ali", new Address("Giza"));
            //Person copy = (Person) original.Clone();

            //// false
            //Console.WriteLine(ReferenceEquals(original, copy));

            //// True
            //Console.WriteLine(ReferenceEquals(original.HomeAddress, copy.HomeAddress));

            //Console.WriteLine($"{original.HomeAddress.GetHashCode()} :: {copy.HomeAddress.GetHashCode()}");
            //Console.WriteLine($"{original.GetHashCode()} :: {copy.GetHashCode()}");

            //copy.Age = 23;
            //Console.WriteLine($"{original.Age} :: {copy.Age}");

            //original.HomeAddress.City = "Cairo";
            //// 
            //Console.WriteLine($"{original.HomeAddress.City} :: {copy.HomeAddress.City}");


            #endregion

            #endregion

            #region Deep Copy

            /*
             * Deep Copy:
             *      - Creates a new object and recursively copies all nested objects.
             *      - The original and the copy are completely independent.
             *
             * Common ways to implement it:
             *      1. Manual implementation (ICloneable / factory method) => new instances for all nested objects.
             *      2. Copy constructor => a constructor that takes an object of the same class and copies everything, returning a new instance with everything copied.
             *      3. Serialization => serialize to json then deserialize back (System.Text.Json).
             */

            #region 1. Manual Deep Copy

            //Person original = new Person(20, "Ali", new Address("Giza"));
            //Person deepCopy = original.DeepCopy();

            //Console.WriteLine(ReferenceEquals(original, deepCopy));
            //Console.WriteLine(ReferenceEquals(original.HomeAddress, deepCopy.HomeAddress));
            //Console.WriteLine($"{original.HomeAddress.GetHashCode()} :: {deepCopy.HomeAddress.GetHashCode()}");

            //original.Name = "Omar";
            //Console.WriteLine($"{original.Name} :: {deepCopy.Name}");

            #endregion

            #region 2. Copy Constructor

            //Person original = new Person(20, "Ali", new Address("Giza"));
            //Person deepCopy = new Person(original);


            //Console.WriteLine(ReferenceEquals(original, deepCopy));
            //Console.WriteLine(ReferenceEquals(original.HomeAddress, deepCopy.HomeAddress));
            //Console.WriteLine($"{original.HomeAddress.GetHashCode()} :: {deepCopy.HomeAddress.GetHashCode()}");


            //deepCopy.HomeAddress.City = "Cairo";

            //Console.WriteLine($"{original.HomeAddress.City} :: {deepCopy.HomeAddress.City}");




            #endregion

            #region 3. Serialization (PersonCloner)

            //Person original = new Person(20, "Ali", new Address("Giza"));
            //Person deepCopy = PersonCloner.DeepCopy(original);

            //// false
            //Console.WriteLine(ReferenceEquals(original, deepCopy));
            //// false
            //Console.WriteLine(ReferenceEquals(original.HomeAddress, deepCopy.HomeAddress));
            //Console.WriteLine($"{original.HomeAddress.GetHashCode()} :: {deepCopy.HomeAddress.GetHashCode()}");


            //deepCopy.HomeAddress.City = "Cairo";

            //Console.WriteLine($"{original.HomeAddress.City} :: {deepCopy.HomeAddress.City}");


            #endregion

            #endregion

        }
    }
}

