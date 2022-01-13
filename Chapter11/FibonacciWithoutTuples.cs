using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter11
{
    [Description("Listing 11.5")]
    class FibonacciWithoutTuples
    {
        static void Main()
        {
            foreach (var value in Fibonacci().Take(10))
            {
                Console.WriteLine(value);
            }
        }

        static IEnumerable<int> Fibonacci()
        {
            int current = 0;
            int next = 1;
            while (true)
            {
                yield return current;
                int nextNext = current + next;
                current = next;
                next = nextNext;
            }
        }
    }
}
