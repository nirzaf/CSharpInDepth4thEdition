using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter05
{
    [Description("Listing 5.3")]
    class AwaitCompletedTask
    {
        static void Main()
        {
            Task task = DemoCompletedAsync();
            Console.WriteLine("Method returned");
            // Safe in a console app - no synchronization context
            task.Wait();
            Console.WriteLine("Task completed");
        }

        static async Task DemoCompletedAsync()
        {
            Console.WriteLine("Before first await");
            await Task.FromResult(10);
            Console.WriteLine("Between awaits");
            await Task.Delay(1000);
            Console.WriteLine("After second await");
        }
    }
}
