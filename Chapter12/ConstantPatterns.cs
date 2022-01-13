using System;
using System.ComponentModel;

namespace Chapter12
{
    [Description("Listing 12.12")]
    class ConstantPatterns
    {
        static void Match(object input)
        {
            if (input is "hello")
                Console.WriteLine("Input is string hello");
            else if (input is 5L)
                Console.WriteLine("Input is long 5");
            else if (input is 10)
                Console.WriteLine("Input is int 10");
            else
                Console.WriteLine("Input didn't match hello, long 5 or int 10");
        }

        static void Main()
        {
            Match("hello");
            Match(5L);
            Match(7);
            Match(10);
            Match(10L);
        }
    }
}
