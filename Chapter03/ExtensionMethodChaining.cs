using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter03
{
    [Description("Listing 3.17")]
    class ExtensionMethodChaining
    {
        static void Main()
        {
            string[] words = { "keys", "coat", "laptop", "bottle" };
            IEnumerable<string> query = words
                .Where(word => word.Length > 4)
                .OrderBy(word => word)
                .Select(word => word.ToUpper());

            foreach (string word in query)
            {
                Console.WriteLine(word);
            }
        }
    }
}
