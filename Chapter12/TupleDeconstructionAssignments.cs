using System;
using System.ComponentModel;

namespace Chapter12
{
    [Description("Listing 12.3")]
    class TupleDeconstructionAssignments
    {
        static (int x, int y, string text) MethodReturningTuple() => (1, 2, "t");

        static void Main()
        {
            int a = 20;
            int b = 30;
            string name = "before";
            Console.WriteLine($"a: {a}; b: {b}; name: {name}");

            (a, b, name) = MethodReturningTuple();

            Console.WriteLine($"a: {a}; b: {b}; name: {name}");
        }
    }
}
