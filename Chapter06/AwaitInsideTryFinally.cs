using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter06
{
    [Description("Listing 6.9")]
    class AwaitInsideTryFinally
    {
        static async Task AwaitInTryFinally(TimeSpan delay)
        {
            Console.WriteLine("Before try block");
            try
            {
                Console.WriteLine("Before await");
                await Task.Delay(delay);
                Console.WriteLine("After await");
            }
            finally
            {
                Console.WriteLine("In finally block");
            }
            Console.WriteLine("After finally block");
        }

        static void Main()
        {
            AwaitInTryFinally(TimeSpan.FromSeconds(1)).Wait();
        }
    }
}
