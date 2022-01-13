using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter10
{
    static class PersonDictionaryExtensions
    {
        public static void Add(
            this Dictionary<string, Person> dictionary, Person person)
        {
            dictionary.Add(person.Name, person);
        }
    }

    [Description("Listing 10.10")]
    class SpecializedAddExtensionMethod
    {
        static void Main()
        {
            Dictionary<string, Person>  dictionary = new Dictionary<string, Person>
            {
                { new Person { Name = "Jon" } },
                { new Person { Name = "Holly" } }
            };
        }
    }
}
