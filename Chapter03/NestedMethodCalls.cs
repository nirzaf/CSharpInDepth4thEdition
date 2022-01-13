using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter03
{
    [Description("Listing 3.18")]
    class NestedMethodCalls
    {
        static void Main()
        {
            string[] words = { "keys", "coat", "laptop", "bottle" };
            IEnumerable<string> query =
                Enumerable.Select(
                    Enumerable.OrderBy(
                        Enumerable.Where(words, word => word.Length > 4),
                        word => word),
                    word => word.ToUpper());

            foreach (string word in query)
            {
                Console.WriteLine(word);
            }
        }
    }
}
