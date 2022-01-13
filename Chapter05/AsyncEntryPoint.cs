using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter05
{
    [Description("Listing 5.11")]
    class AsyncEntryPoint
    {
        static async Task Main()
        {
            Console.WriteLine("Before delay");
            await Task.Delay(1000);
            Console.WriteLine("After delay");
        }
    }
}
