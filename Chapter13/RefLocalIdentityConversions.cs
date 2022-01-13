using System;
using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.5")]
    class RefLocalIdentityConversions
    {
        static void Main()
        {
            (int x, int y) tuple1 = (10, 20);
            ref (int a, int b) tuple2 = ref tuple1;
            tuple2.a = 30;
            Console.WriteLine(tuple1.x);
        }
    }
}
