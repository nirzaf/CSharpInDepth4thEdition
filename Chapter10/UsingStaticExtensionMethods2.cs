using System.Collections.Generic;
using System.ComponentModel;
using static System.Linq.Enumerable;

namespace Chapter10
{
    [Description("Listing 10.4")]
    class UsingStaticExtensionMethods2
    {
        static void Main()
        {
            IEnumerable<string> strings = new[] { "a", "b", "c" };

            int valid = strings.Count();
            // int invalid = Count(strings);
        }
    }
}
