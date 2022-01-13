using System;
using System.ComponentModel;
using System.Linq;

namespace Chapter11
{
    [Description("Listing 11.9")]
    class RegularComparisons
    {
        static void Main()
        {
            var points = new[]
            {
                (1, 2), (10, 3), (-1, 5), (2, 1),
                (10, 3), (2, 1), (1, 1)
            };

            var distinctPoints = points.Distinct();
            Console.WriteLine($"{distinctPoints.Count()} distinct points");
            Console.WriteLine("Points in order:");
            foreach (var point in distinctPoints.OrderBy(p => p))
            {
                Console.WriteLine(point);
            }
        }
    }
}
