using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chapter14
{
    [Description("Listing 14.7")]
    class LocalMethodVariableCapture3Equivalent
    {
        static void Main()
        {
            Action counter = CreateCounter();
            counter();
            counter();
        }

        static Action CreateCounter()
        {
            CountHolder holder = new CountHolder();
            holder.count = 0;
            return holder.Count;
        }

        private class CountHolder
        {
            public int count;

            public void Count() => Console.WriteLine(count++);
        }
    }
}
