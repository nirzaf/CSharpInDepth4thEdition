using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter11
{
    class MinMax4
    {
        static void Main()
        {
            Random rng = new Random();
            var numbers = Enumerable.Range(0, 100).Select(_ => rng.Next(1000));
            var minMax = MinMax(numbers);
            Console.WriteLine($"Minimum: {minMax.min}");
            Console.WriteLine($"Maximum: {minMax.max}");
        }

        static (int min, int max) MinMax(IEnumerable<int> source) =>
            source.Aggregate(
                first => (first, first),
                ((int min, int max) result, int next) => (Math.Min(result.min, next), Math.Max(result.max, next))
            );
    }

    public static class MoreEnumerables
    {
        public static TAccumulate Aggregate<TSource, TAccumulate>(
            this IEnumerable<TSource> source,
            Func<TSource, TAccumulate> seedSelector,
            Func<TAccumulate, TSource, TAccumulate> func)
        {
            using (var iterator = source.GetEnumerator())
            {
                if (!iterator.MoveNext())
                {
                    throw new InvalidOperationException("Empty sequence");
                }
                var accumulator = seedSelector(iterator.Current);
                while (iterator.MoveNext())
                {
                    accumulator = func(accumulator, iterator.Current);
                }
                return accumulator;
            }
        }
    }
}
