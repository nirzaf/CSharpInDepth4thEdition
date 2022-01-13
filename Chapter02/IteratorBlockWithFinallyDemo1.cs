using System;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.15")]
    class IteratorBlockWithFinallyDemo1
    {
        static void Main()
        {
            foreach (string value in IteratorBlockWithFinally.Iterator())
            {
                Console.WriteLine("Received value: {0}", value);
            }
        }
    }
}
