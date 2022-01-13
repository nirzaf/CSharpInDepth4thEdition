using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter08
{
    [Description("Listing 8.10")]
    public class Person
    {
        public List<Person> Friends { get; } = new List<Person>();
    }
}
