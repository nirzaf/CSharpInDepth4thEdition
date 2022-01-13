using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter03
{
    [Description("Listing 3.19")]
    class QueryWithLocalVariables
    {
        static void Main()
        {
            string[] words = { "keys", "coat", "laptop", "bottle" };
            var tmp1 = Enumerable.Where(words, word => word.Length > 4);
            var tmp2 = Enumerable.OrderBy(tmp1, word => word);
            IEnumerable<string> query = Enumerable.Select(tmp2, word => word.ToUpper());

            foreach (string word in query)
            {
                Console.WriteLine(word);
            }
        }
    }
}
