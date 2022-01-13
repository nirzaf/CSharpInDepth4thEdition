using System;
using System.ComponentModel;

namespace Chapter12
{
    [Description("Listing 12.2")]
    class TupleDeconstructionExplicitTyping
    {
        static (int x, int y, string text) MethodReturningTuple() => (1, 2, "t");

        static void Main()
        {
            (int a, int b, string name) = MethodReturningTuple();
            Console.WriteLine($"a: {a}; b: {b}; name: {name}");
        }
    }
}
