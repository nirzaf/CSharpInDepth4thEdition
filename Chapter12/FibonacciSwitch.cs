using System;
using System.ComponentModel;

namespace Chapter12
{
    [Description("Listing 12.17")]
    class FibonacciSwitch
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Fib({i}) = {Fib(i)}");
            }
        }

        // Note: this is a really inefficient way of computing a Fibonacci number,
        // but it's a good example of pattern matching. See chapter 9 for
        // more efficient approaches.
        static int Fib(int n)
        {
            switch (n)
            {
                case 0: return 0;
                case 1: return 1;
                case var _ when n > 1: return Fib(n - 2) + Fib(n - 1);
                default: throw new ArgumentOutOfRangeException(nameof(n), "Input must be non-negative");
            }
        }
    }
}
