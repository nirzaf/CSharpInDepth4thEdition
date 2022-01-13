using System;

namespace Chapter13
{
    class RefReturnAsRefArgument
    {
        static void Main()
        {
            int x = 10;
            RefReturn(ref RefReturn(ref RefReturn(ref x)))++;
            Console.WriteLine(x);
        }

        static ref int RefReturn(ref int p)
        {
            return ref p;
        }
    }
}
