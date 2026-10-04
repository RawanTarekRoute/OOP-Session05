namespace Route.OOP05.ObjectCopying
{
    internal class Person: ICloneable
    {
        public int Age;
        public string Name;
        public Address HomeAddress;
        public string[] phones;

        public Person()
        {

        }

        public Person(int age, string name, Address homeAddress)
        {
            Age = age;
            Name = name;
            HomeAddress = homeAddress;
            phones = [];
        }

        public Person (Person original)
        {
            if (original is null)
                throw new ArgumentNullException(nameof(original), "Orignal object can't be null");

            //ShallowCopy();

            Name = original.Name ?? string.Empty;
            Age = original.Age;

            HomeAddress = original.HomeAddress is null ?
               new Address() : new Address(original.HomeAddress.City);

            phones = original.phones is null ? [] : (string[]) original.phones.Clone();

        }

        public object Clone()
        {
            return ShallowCopy();
        }

        public Person ShallowCopy()
        {
            return (Person) MemberwiseClone();
        }

        public Person DeepCopy() {

            // 1. Shallow Copy
            Person copy = ShallowCopy();  // (Person) MemberwiseClone();

            copy.HomeAddress = HomeAddress is null ?
                new Address() : new Address(HomeAddress.City);

            copy.phones = phones is null ? [] : (string[]) phones.Clone();

            return copy;


        }

    }
}
