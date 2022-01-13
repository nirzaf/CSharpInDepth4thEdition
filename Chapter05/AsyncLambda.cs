using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter05
{
    [Description("Listing 5.8")]
    class AsyncLambda
    {
        static void Main()
        {
            Func<int, Task<int>> function = async x =>
            {
                Console.WriteLine("Starting... x={0}", x);
                await Task.Delay(x * 1000);
                Console.WriteLine("Finished... x={0}", x);
                return x * 2;
            };
            Task<int> first = function(5);
            Task<int> second = function(3);
            Console.WriteLine("First result: {0}", first.Result);
            Console.WriteLine("Second result: {0}", second.Result);
        }
    }
}
