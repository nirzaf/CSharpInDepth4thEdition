using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chapter12
{
    [Description("Listing 12.18")]
    class NumericBounds
    {
        static void Main()
        {
            CheckBounds(10);
            CheckBounds(10000);
            CheckBounds(10000L);
            CheckBounds(100000L);
            CheckBounds(-10000L);
        }

        static void CheckBounds(object input)
        {
            switch (input)
            {
                case int x when x > 1000:
                case long y when y > 10000L:
                    Console.WriteLine("Value is too large");
                    break;
                case int x when x < -1000:
                case long y when y < -10000L:
                    Console.WriteLine("Value is too low");
                    break;
                default:
                    Console.WriteLine("Value is in range");
                    break;
            }
        }
    }
}
