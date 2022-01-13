using System;
using System.ComponentModel;

#pragma warning disable CS0649

namespace Chapter09
{
    [Description("Listing 9.12")]
    class SimpleNameof
    {
        private string field;

        static void Main(string[] args)
        {
            Console.WriteLine(nameof(SimpleNameof));
            Console.WriteLine(nameof(Main));
            Console.WriteLine(nameof(args));
            Console.WriteLine(nameof(field));
        }
    }
}
