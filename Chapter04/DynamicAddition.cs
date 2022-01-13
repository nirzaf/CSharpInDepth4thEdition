using System;
using System.ComponentModel;

namespace Chapter04
{
    [Description("Listing 4.2")]
    class DynamicAddition
    {
        static void Add(dynamic d)
        {
            Console.WriteLine(d + d);
        }

        static void Main()
        {
            Add("text");
            Add(10);
            Add(TimeSpan.FromMinutes(45));
        }
    }
}
