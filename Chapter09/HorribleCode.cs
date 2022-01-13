using System;

namespace Chapter09
{
    class HorribleCode
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"Hello {((Func<string>)(() =>
            {
                Console.Write("What's your name? ");
                return Console.ReadLine();
            }))()}!");
        }
    }
}
