using System;
using System.ComponentModel;

namespace NullableReferences
{
    [Description("Listing 15.7")]
    class DamnItOperator
    {
        static void PrintLength(string? text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                Console.WriteLine($"{text}: {text!.Length}");
            }
            else
            {
                Console.WriteLine("Empty or null");
            }
        }

        static void Main()
        {
            PrintLength(null);
            PrintLength("");
            PrintLength("foo");
        }
    }
}
