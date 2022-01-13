using System;
using System.ComponentModel;
using System.Text;

namespace Chapter12
{
    [Description("Listing 12.6")]
    class TupleDeconstructionEvaluationOrderingExplained
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder("12345");
            StringBuilder original = builder;

            StringBuilder targetForLength = builder;

            (StringBuilder, int) tuple = (new StringBuilder("67890"), 3);

            builder = tuple.Item1;
            targetForLength.Length = tuple.Item2;

            Console.WriteLine(original);
            Console.WriteLine(builder);
        }
    }
}
