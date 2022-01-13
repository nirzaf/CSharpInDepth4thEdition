using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter14
{
    [Description("Listing 14.1")]
    class LocalMethodIntro
    {
        static void Main()
        {
            int x = 10;
            PrintAndIncrementX();
            PrintAndIncrementX();
            Console.WriteLine($"After calls, x = {x}");

            void PrintAndIncrementX()
            {
                Console.WriteLine($"x = {x}");
                x++;
            }
        }
    }
}
