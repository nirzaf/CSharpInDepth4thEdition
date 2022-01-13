using System;

namespace Chapter13
{
    class InParameterOverloading
    {
        static void Method(int x) =>
            Console.WriteLine("Value parameter");

        static void Method(in int x) =>
            Console.WriteLine("In parameter");

        static void Main()
        {
            int x = 5;
            Method(5);
            Method(x);
            Method(in x);
        }
    }
}
