using Route.OOP05.AbstractClass;
using Route.OOP05.ExtensionMethods;
using Route.OOP05.ObjectCopying;
using Route.OOP05.PartialClasses;

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

            #region Static

            /*
             * Static members belong to the class, not to any instance.
             * There is only one copy of a static member, shared by all objects.
             * Accessed using the class name, without creating an object.
             * Created once and exist for the lifetime of the application.
             * The static keyword can be used with: fields, methods, properties, constructors, classes.
             *
             * Static Member                              | Instance Member
             * Belongs to the class                       | Belongs to an object
             * One copy shared by all objects             | Each object has its own copy
             * Accessed using class name                  | Accessed using object reference
             * Cannot access instance members directly    | Can access both static and instance members
             */

            #region Static Field, Property And Method 

            //// personCount = 1
            //Person p1 = new Person(20, "Ali", new Address("Giza"));

            //// personCount = 2
            //Person p2 = new Person(20, "Ahmed", new Address("Giza"));
            //Console.WriteLine(p2.CreatePerson())

            //Console.WriteLine(Person.TotalPeople);


            #endregion

            #region Static Constructor

            /*
             * Used to initialize static members of the class.
             * Called automatically by the CLR, cannot be called manually.
             * Called one time only, before the first use of the class.
             * Cannot take any parameters.
             * Always private, cannot write access modifiers.
             *
             * The class is used for the first time when:
             *      1. An object is created using new.
             *      2. A static member is accessed.
             *      3. A child class is instantiated.
             */


            // 1. when creating a first instance from the class
            //Person p3 = new Person(10, "Ali", new Address());
            //Console.WriteLine(Person.DefaultCity);

            //Person p4 = new Person(10, "Ali", new Address());


            // 2. when accessing static method for the first time
            //Console.WriteLine(Person.CreatePerson());
            //Console.WriteLine(Person.CreatePerson());
            //Console.WriteLine(Person.CreatePerson());

            // 3. when creating a first instance from a child class
            //Employee employee = new Employee();
            //Employee employee02 = new Employee();




            #endregion

            #region Static Class

            /*
             * A class declared as static cannot be instantiated.
             * All members of a static class must be static.
             * Useful for grouping related static members (utility classes).
             * 
             * Important points:
             *  - Static members cannot access instance members directly.
             *  - Instance members can access static members.
             *  - You cannot use this or base in a static context.
             *  
             * When to use static classes:
             *  -  When the data or behavior is the same for all objects.
             *  -  Utility / helper classes (Math, String, Console).
             *  -  Methods that don't depend on object state.
             */

            //Logger logger = new Logger();

            #endregion



            #endregion

            #region Partial Class, Method

            /*
             * A partial class splits the definition of a class into multiple files.
             * All parts are combined by the compiler into a single class.
             * It is a compile-time feature, at runtime it is just one normal class.
             *
             * Why it exists:
             *      - Organize large classes across multiple files.
             *      - Separate auto-generated code from custom code.
             *      - Allow different team members or tools to extend a class without modifying the original file.
             *
             * Rules:
             *      - All parts must use the partial keyword.
             *      - All parts must be in the same namespace.
             *      - All parts must have the same accessibility.
             *      - All parts must be compiled together in the same assembly.
             *
             * Partial struct and partial interface are also supported.
             * Partial classes can't be nested inside other classes as a way of splitting a top level class.
             */

            /*
             * A partial method is a method declaration without an implementation.
             * It can be optionally implemented in another part.
             * If it is not implemented, the call is removed by the compiler.
             * Partial methods are private and return void (when declared without an access modifier).
             */

            //Report report = new Report("First Report");
            //Console.WriteLine(report.Title);
            //Console.WriteLine(report.GeneratedTime);
            //report.Generate();



            #endregion

            #region Extension Methods

            /*
             * Extension methods let you add new methods to existing types without modifying the original type or creating a derived type.
             *
             * Key points:
             *      - Must be defined in a static class.
             *      - Must be a static method.
             *      - The first parameter must use the this modifier.
             *      - The extended type is the type of the first parameter.
             *      - Called using instance method syntax (.)
             *      - The namespace of the static class must be imported (using).
             *
             * Extension methods do NOT actually modify the type, they are just syntactic sugar for static methods.
             * They cannot access private or protected members of the type.
             * Extra parameters after the this parameter are passed by the caller.
             * 
             * Benefits:
             *  - Improve readability and maintainability.
             *  - Add utility methods to existing types (string, int, DateTime).
             *  - Encapsulate common logic.
             */

            //int number = 10;

            //Console.WriteLine(number.IsEven());
            //Console.WriteLine(IntExtensions.IsEven(number));


            Person person = new Person(25, "Ali", new Address());
            Console.WriteLine(person.IsAdult());

            #endregion

        }
    }
}

