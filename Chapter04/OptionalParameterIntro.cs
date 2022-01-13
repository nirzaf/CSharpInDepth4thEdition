using System;
using System.ComponentModel;

namespace Chapter04
{
    [Description("Listing 4.14")]
    class OptionalParameterIntro
    {
        static void Method(int x, int y = 5, int z = 10)
        {
            Console.WriteLine("x={0}; y={1}; z={2}", x, y, z);
        }

        static void Main()
        {
            Method(1, 2, 3);
            Method(x: 1, y: 2, z: 3);
            Method(z: 3, y: 2, x: 1);
            Method(1, 2);
            Method(1, y: 2);
            Method(1, z: 3);
            Method(1);
        }
    }
}
