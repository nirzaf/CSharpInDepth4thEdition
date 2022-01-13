using System;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.16")]
    class IteratorBlockWithFinallyDemo2
    {
        static void Main()
        {
            foreach (string value in IteratorBlockWithFinally.Iterator())
            {
                Console.WriteLine("Received value: {0}", value);
                if (value != null)
                {
                    break;
                }
            }
        }
    }
}
