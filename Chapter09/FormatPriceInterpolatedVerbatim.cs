using System;
using System.ComponentModel;

namespace Chapter09
{
    [Description("Listing 9.4")]
    public class FormatPriceInterpolatedVerbatim
    {
        static void Main()
        {
            decimal price = 95.25m;
            decimal tip = price * 0.2m;
            Console.WriteLine($@"Price: {price,9:C}
Tip:   {tip,9:C}
Total: {price + tip,9:C}");            
        }
    }
}
