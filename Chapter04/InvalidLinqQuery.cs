using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter04
{
    [Description("Listing 4.10")]
    class InvalidLinqQuery
    {
        static void Main()
        {
            dynamic source = new List<dynamic>
            {
                5,
                2.75,
                TimeSpan.FromSeconds(45)
            };
            // This fails at execution time:
            bool result = source.Any();

            // This would work:
            // bool result = Enumerable.Any(source);
        }
    }
}
