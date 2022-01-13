using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter06
{
    [Description("Listing 6.7")]
    class AwaitInsideLoop
    {
        static async Task AwaitInLoop(TimeSpan delay)
        {
            Console.WriteLine("Before loop");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Before await in loop");
                await Task.Delay(delay);
                Console.WriteLine("After await in loop");
            }
            Console.WriteLine("After loop delay");
        }

        static void Main()
        {
            AwaitInLoop(TimeSpan.FromSeconds(1)).Wait();
        }
    }
}
