using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chapter02
{
    [Description("Listing 2.12")]
    class ExpandedForEach
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
            IEnumerable<int> enumerable = CreateSimpleIterator();
            using (IEnumerator<int> enumerator = enumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    int value = enumerator.Current;
                    Console.WriteLine(value);
                }
            }
        }
    }
}
