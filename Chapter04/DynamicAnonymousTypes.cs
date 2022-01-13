using System;
using System.ComponentModel;

namespace Chapter04
{
    [Description("Listing 4.12")]
    class DynamicAnonymousTypes
    {
        static void PrintName(dynamic obj)
        {
            Console.WriteLine(obj.Name);
        }

        static void Main()
        {
            var x = new { Name = "Abc" };
            var y = new { Name = "Def", Score = 10 };
            PrintName(x);
            PrintName(y);
        }
    }
}
