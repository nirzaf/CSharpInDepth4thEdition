using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter03
{
    [Description("Listing 3.22")]
    class QueryExpression2Impl
    {
        static void Main()
        {
            string[] words = { "keys", "coat", "laptop", "bottle" };
            IEnumerable<string> query = words
                .Select(word => new { word, length = word.Length })
                .Where(tmp => tmp.length > 4)
                .OrderBy(tmp => tmp.length)
                .Select(tmp => string.Format("{0}: {1}", tmp.length, tmp.word.ToUpper()));

            foreach (string item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
