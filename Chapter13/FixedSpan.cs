using System;

namespace Chapter13
{
    class FixedSpan
    {
        unsafe static void Main()
        {
            string test = "Test";
            ReadOnlySpan<char> span = test;

            // Yes, this modifies a string...
            fixed (char* ptr = span)
            {
                *ptr = 'X';
            }

            // But you could do that directly anyway
            fixed (char* ptr = test)
            {
                *(ptr + 1) = 'Y';
            }
            // Prints XYst
            Console.WriteLine(test);
        }
    }
}
