using System;

namespace Chapter13
{
    class RefReassignment
    {
        static void Main()
        {
            int x = 10;
            int y = 20;
            ref int r = ref x;
            r++;
            r = ref y;
            r++;
            Console.WriteLine($"x={x}; y={y}");
        }
    }
}
