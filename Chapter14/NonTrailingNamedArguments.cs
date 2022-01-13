using System;

namespace Chapter14
{
    class NonTrailingNamedArguments
    {
        static void Method(int x, int y = 5, int z = 10)
        {
            Console.WriteLine("x={0}; y={1}; z={2}", x, y, z);
        }

        static void Main()
        {
            Method(x: 1, y: 2, 3);
        }
    }
}
