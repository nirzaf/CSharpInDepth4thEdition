using System;
using System.ComponentModel;

namespace Chapter11
{
    [Description("Listing 11.X")]
    class EqualityOperators
    {
        static void Main()
        {
            var t1 = (x: "x", y: "y", z: 1);
            var t2 = ("x", "y", 1);
            Console.WriteLine(t1 == t2);

            Console.WriteLine(t1.Item1 == t2.Item1 &&
                                t1.Item2 == t2.Item2 &&
                                t1.Item3 == t2.Item3);

            Console.WriteLine(t1 != t2);
            Console.WriteLine(t1.Item1 != t2.Item1 &&
                                t1.Item2 != t2.Item2 &&
                                t1.Item3 != t2.Item3);
        }
    }
}
