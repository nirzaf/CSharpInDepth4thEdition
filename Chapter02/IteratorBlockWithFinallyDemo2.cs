using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.17")]
    class IteratorBlockWithFinallyDemo3
    {
        static void Main()
        {
            IEnumerable<string> enumerable = IteratorBlockWithFinally.Iterator();
            using (IEnumerator<string> enumerator = enumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    string value = enumerator.Current;
                    Console.WriteLine("Received value: {0}", value);
                    if (value != null)
                    {
                        break;
                    }
                }
            }
        }
    }
}
