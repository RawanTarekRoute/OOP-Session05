using System.Text.Json;

namespace Route.OOP05.ObjectCopying
{
    internal static class PersonCloner
    {
        private static readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        public static Person DeepCopy(Person original)
        {
            // 1. Convert C# object to JSON string (Serialization)

            string json = JsonSerializer.Serialize(original,options: options);

            // 2. Convert JSON  to C# object again (Deserialization)
            // returning new instance (deep copied)
            return JsonSerializer.Deserialize<Person>(json, options)!;
        }
    }
}
