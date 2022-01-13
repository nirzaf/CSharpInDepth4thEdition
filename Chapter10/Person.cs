using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter10
{
    class Person
    {
        public string Name { get; set; }
        public string Town { get; set; }
        public List<Person> Contacts { get; } = new List<Person>();
    }
}
