using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chapter14
{
    [Description("Listing 14.6")]
    class LocalMethodVariableCapture3
    {
        static void Main()
        {
            Action counter = CreateCounter();
            counter();
            counter();
        }

        static Action CreateCounter()
        {
            int count = 0;
            return Count;
            void Count() => Console.WriteLine(count++);
        }
    }
}
