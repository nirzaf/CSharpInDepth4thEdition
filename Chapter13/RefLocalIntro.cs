using System;
using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.2")]
    public class RefLocalIntro
    {
        static void Main()
        {
            int x = 10;
            ref int y = ref x;
            x++;
            y++;
            Console.WriteLine(x);
        }
    }
}
