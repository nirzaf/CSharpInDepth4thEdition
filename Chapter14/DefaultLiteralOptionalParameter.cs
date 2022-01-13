using System;
using System.ComponentModel;

namespace Chapter14
{
    [Description("Listing 14.11")]
    class DefaultLiteralOptionalParameter
    {
        static void PrintValue(int value = 10)
        {
            Console.WriteLine(value);
        }

        static void Main()
        {
            PrintValue(default);
        }
    }
}
