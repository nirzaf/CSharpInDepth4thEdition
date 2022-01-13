using System;
using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.13")]
    class InParameterSideEffects
    {
        static void InParameter(in int p, Action action)
        {
            Console.WriteLine("Start of InParameter method");
            Console.WriteLine($"p = {p}");
            action();
            Console.WriteLine($"p = {p}");
        }

        static void ValueParameter(int p, Action action)
        {
            Console.WriteLine("Start of ValueParameter method");
            Console.WriteLine($"p = {p}");
            action();
            Console.WriteLine($"p = {p}");
        }

        static void Main()
        {
            int x = 10;
            InParameter(x, () => x++);

            int y = 10;
            ValueParameter(y, () => y++);
        }
    }
}
