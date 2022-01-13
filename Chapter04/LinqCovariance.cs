using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter04
{
    [Description("Listing 4.20")]
    class LinqCovariance
    {
        static void Main()
        {
            IEnumerable<string> strings = new[] { "a", "b", "cdefg", "hij" };
            List<object> list = strings
                .Where(x => x.Length > 1)
                .ToList<object>();
        }
    }
}
