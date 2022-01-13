using System;
using System.ComponentModel;
using System.Text;

namespace Chapter12
{
    [Description("Listing 12.5")]
    class TupleDeconstructionEvaluationOrdering
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder("12345");
            StringBuilder original = builder;

            (builder, builder.Length) = (new StringBuilder("67890"), 3);

            Console.WriteLine(original);
            Console.WriteLine(builder);
        }
    }
}
