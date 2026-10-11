using Route.OOP05.ObjectCopying;

namespace Route.OOP05.ExtensionMethods
{
    internal static class PersonExtensions
    {

        public static bool IsAdult(this Person person)
        {
            return person.Age > 21;
        }
    }
}
