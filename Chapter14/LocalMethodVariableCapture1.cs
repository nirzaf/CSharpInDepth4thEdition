using System;
using System.ComponentModel;

namespace Chapter14
{
    [Description("Listing 14.2")]
    class LocalMethodVariableCapture1
    {
        static void Main()
        {
            int i = 0;
            AddToI(5);
            AddToI(10);
            Console.WriteLine(i);
            void AddToI(int amount) => i += amount;
        }
    }
}
