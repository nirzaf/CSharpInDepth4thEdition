using System;

namespace Chapter13
{
    class StackAllocWithInitializer
    {
        unsafe static void Main()
        {
            Span<int> span = stackalloc int[] { 1, 2, 3 };
            int* pointer = stackalloc int[] { 4, 5, 6 };
        }
    }
}
