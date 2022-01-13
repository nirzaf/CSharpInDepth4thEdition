using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter10
{
    [Description("Listing 10.7")]
    public sealed class SchemalessEntity : IEnumerable<KeyValuePair<string, object>>
    {
        private readonly IDictionary<string, object> properties =
            new Dictionary<string, object>();

        public string Key { get; set; }
        public string ParentKey { get; set; }

        public object this[string propertyKey]
        {
            get { return properties[propertyKey]; }
            set { properties[propertyKey] = value; }
        }

        public void Add(string propertyKey, object value)
        {
            properties.Add(propertyKey, value);
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() =>
            properties.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    [Description("Listing 10.8")]
    class SchemalessEntityInitialization
    {
        static void Main()
        {
            // Using a collection initializer.
            SchemalessEntity parent = new SchemalessEntity { Key = "parent-key" };
            SchemalessEntity child1 = new SchemalessEntity
            {
                { "name", "Jon Skeet" },
                { "location", "Reading, UK" }
            };
            child1.Key = "child-key";
            child1.ParentKey = parent.Key;

            // Using an object initializer
            SchemalessEntity child2 = new SchemalessEntity
            {
                Key = "child-key",
                ParentKey = parent.Key,
                ["name"] = "Jon Skeet",
                ["location"] = "Reading, UK"
            };
        }
    }
}
