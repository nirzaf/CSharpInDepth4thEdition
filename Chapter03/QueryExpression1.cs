using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter03
{
    [Description("Listing 3.20")]
    class QueryExpression1
    {
        static void Main()
        {
            string[] words = { "keys", "coat", "laptop", "bottle" };
            IEnumerable<string> query = from word in words
                                        where word.Length > 4
                                        orderby word
                                        select word.ToUpper();

            foreach (string word in query)
            {
                Console.WriteLine(word);
            }
        }
    }
}
