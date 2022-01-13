using System;
using System.ComponentModel;

namespace Chapter14
{
    [Description("Listing 14.5")]
    class LocalMethodVariableCapture2Equivalent
    {
        struct OuterScope
        {
            public int hour;
        }

        struct InnerScope
        {
            public int minute;
        }

        static void Main()
        {
            DateTime now = DateTime.UtcNow;
            OuterScope outer = new OuterScope();
            outer.hour = now.Hour;
            if (outer.hour > 5)
            {
                InnerScope inner = new InnerScope();
                inner.minute = now.Minute;
                PrintValues(ref outer, ref inner);
            }
        }

        static void PrintValues(ref OuterScope outer, ref InnerScope inner)
        {
            Console.WriteLine($"hour = {outer.hour}; minute = {inner.minute}");
        }
    }
}
