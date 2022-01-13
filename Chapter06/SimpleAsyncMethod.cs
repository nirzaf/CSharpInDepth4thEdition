using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter06
{
    [Description("Listing 6.1")]
    class SimpleAsyncMethod
    {
        static async Task PrintAndWait(TimeSpan delay)
        {
            Console.WriteLine("Before first delay");
            await Task.Delay(delay);
            Console.WriteLine("Between delays");
            await Task.Delay(delay);
            Console.WriteLine("After second delay");
        }

        static void Main()
        {
            PrintAndWait(TimeSpan.FromSeconds(1)).Wait();
        }
    }
}
