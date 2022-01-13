using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter04
{
    [Description("Listing 4.11")]
    class DynamicLinqQueryWithQueryable
    {
        static void Main()
        {
            List<dynamic> source = new List<dynamic>
            {
                5,
                2.75,
                TimeSpan.FromSeconds(45)
            };

            /* Uncomment to see the compilation failure
            IEnumerable<dynamic> query = source
                .AsQueryable()
                .Select(x => x * 2);
            foreach (dynamic value in query)
            {
                Console.WriteLine(value);
            }*/
        }
    }
}
