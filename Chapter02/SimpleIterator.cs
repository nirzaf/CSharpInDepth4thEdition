using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chapter02
{
    [Description("Listing 2.11")]
    class SimpleIterator
    {
        static IEnumerable<int> CreateSimpleIterator()
        {
            yield return 10;
            for (int i = 0; i < 3; i++)
            {
                yield return i;
            }
            yield return 20;
        }

        static void Main()
        {
            foreach (int value in CreateSimpleIterator())
            {
                Console.WriteLine(value);
            }
        }
    }
}
