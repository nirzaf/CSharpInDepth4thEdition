using System;
using System.ComponentModel;

namespace Chapter09
{
    [Description("Listing 9.1")]
    public class FormatPrice
    {
        static void Main()
        {
            decimal price = 95.25m;
            decimal tip = price * 0.2m; // 20% tip
            Console.WriteLine("Price: {0,9:C}", price);
            Console.WriteLine("Tip:   {0,9:C}", tip);
            Console.WriteLine("Total: {0,9:C}", price + tip);
        }
    }
}
