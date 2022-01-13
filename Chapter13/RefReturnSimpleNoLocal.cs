using System;
using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.7")]
    class RefReturnSimpleNoLocal
    {
        static void Main()
        {
            int x = 10;
            RefReturn(ref x)++;
            Console.WriteLine(x);
        }

        static ref int RefReturn(ref int p)
        {
            return ref p;
        }
    }
}
