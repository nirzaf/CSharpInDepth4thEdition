using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter11
{
    [Description("Listing 11.4")]
    class MinMax3
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
                var result = (min: iterator.Current, max: iterator.Current);
                while (iterator.MoveNext())
                {
                    result = (Math.Min(result.min, iterator.Current),
                              Math.Max(result.max, iterator.Current));
                }
                return result;
            }
        }
    }
}
