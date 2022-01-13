using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter06
{
    [Description("Listing 6.6")]
    class AsyncMethodWithSimpleLoop
    {
        static async Task PrintAndWaitWithSimpleLoop(TimeSpan delay)
        {
            Console.WriteLine("Before first delay");
            await Task.Delay(delay);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Between delays");
            }
            await Task.Delay(delay);
            Console.WriteLine("After second delay");
        }

        static void Main()
        {
            PrintAndWaitWithSimpleLoop(TimeSpan.FromSeconds(1)).Wait();
        }
    }
}
