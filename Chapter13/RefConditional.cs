using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.9")]
    class RefConditional
    {
        static void Main()
        {
            var counts = CountEvenAndOdd(new[] { 1, 5, 2, 3, 4 });
            Console.WriteLine($"Even: {counts.even}");
            Console.WriteLine($"Odd: {counts.odd}");
        }

        static (int even, int odd) CountEvenAndOdd(IEnumerable<int> values)
        {
            var result = (even: 0, odd: 0);
            foreach (var value in values)
            {
                ref int counter = ref (value & 1) == 0 ? ref result.even : ref result.odd;
                counter++;
            }
            return result;
        }
    }
}
