using System;
using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.6")]
    class RefReturnSimple
    {
        static void Main()
        {
            int x = 10;
            ref int y = ref RefReturn(ref x);
            y++;
            Console.WriteLine(x);
        }

        static ref int RefReturn(ref int p)
        {
            return ref p;
        }
    }
}
