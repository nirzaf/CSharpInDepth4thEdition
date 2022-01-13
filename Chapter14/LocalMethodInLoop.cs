using System;

namespace Chapter14
{
    class LocalMethodInLoop
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                PrintI();

                void PrintI()
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
