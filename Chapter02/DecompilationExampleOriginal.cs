using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chapter02
{
    [Description("Listing 2.19")]
    class DecompilationExampleOriginal
    {
        public static IEnumerable<int> GenerateIntegers(int count)
        {
            try
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Yielding {0}", i);
                    yield return i;
                    int doubled = i * 2;
                    Console.WriteLine("Yielding {0}", doubled);
                    yield return doubled;
                }
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
        }

        static void Main()
        {
            foreach (int value in GenerateIntegers(5))
            {
                Console.WriteLine(value);
            }
        }
    }
}
