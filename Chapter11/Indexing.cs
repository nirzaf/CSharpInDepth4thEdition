using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter11
{
    static class Indexing
    {
        static void Main()
        {
            string[] array = { "first", "second", "third" };
            foreach (var pair in array.WithIndex())
            {
                Console.WriteLine(pair);
            }
        }

        static IEnumerable<(T value, int index)> WithIndex<T>
            (this IEnumerable<T> source) =>
            source.Select((value, index) => (value, index));
    }
}
