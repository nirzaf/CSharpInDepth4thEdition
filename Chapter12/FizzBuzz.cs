using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter12
{
    class FizzBuzz
    {
        static void Main()
        {
            for (int i = 1; i < 50; i++)
            {
                PrintFizzBuzz(i);
            }
        }

        static void PrintFizzBuzz(int n)
        {
            switch (n)
            {
                case var _ when n % 3 == 0:
                    Console.Write("Fizz");
                    goto case 0;
                case 0:
                    break;
                case var _ when n % 5 == 0:
                    Console.Write("Buzz");
                    break;
                default:
                    Console.WriteLine(n);
                    break;
            }
        }
    }
}
