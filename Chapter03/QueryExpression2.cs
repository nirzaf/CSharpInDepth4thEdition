using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter03
{
    [Description("Listing 3.21")]
    class QueryExpression2
    {
        static void Main()
        {
            string[] words = { "keys", "coat", "laptop", "bottle" };
            IEnumerable<string> query = from word in words
                                        let length = word.Length
                                        where length > 4
                                        orderby length
                                        select string.Format("{0}: {1}", length, word.ToUpper());

            foreach (string item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
