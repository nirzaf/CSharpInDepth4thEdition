using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    static class ListExtensions
    {
        public static void Add<T>(this List<T> list, IEnumerable<T> collection)
        {
            list.AddRange(collection);
        }
    }
    class AddRangeAsAdd
    {
        static void Main()
        {
            List<Person> allContacts = new List<Person>
            {
                new Person { Name = "Holly", Town = "Reading" },
                new Person { Name = "Gareth", Town = "Cambridge" }
            };

            var jon = new Person
            {
                Name = "Jon",
                Contacts = { allContacts.Where(c => c.Town == "Reading") }
            };
        }
    }
}
