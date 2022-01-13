using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter11
{
    [Description("Listing 11.1")]
    class MinMax1
    {
        static void Main()
        {
            Random rng = new Random();
            var numbers = Enumerable.Range(0, 100).Select(_ => rng.Next(1000));
            var minMax = MinMax(numbers);
            Console.WriteLine($"Minimum: {minMax.min}");
            Console.WriteLine($"Maximum: {minMax.max}");
        }

        static (int min, int max) MinMax(IEnumerable<int> source)
        {
            using (var iterator = source.GetEnumerator())
            {
                if (!iterator.MoveNext())
                {
                    throw new InvalidOperationException("Cannot find min/max of an empty sequence");
                }
                int min = iterator.Current;
                int max = iterator.Current;
                while (iterator.MoveNext())
                {
                    min = Math.Min(min, iterator.Current);
                    max = Math.Max(max, iterator.Current);
                }

                return (min, max);
            }

        }
    }
}
