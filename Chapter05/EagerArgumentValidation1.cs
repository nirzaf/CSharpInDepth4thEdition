using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter05
{
    [Description("Listing 5.6a (separate method for implementation)")]
    class EagerArgumentValidation1
    {
        static void Main()
        {
            MainAsync().GetAwaiter().GetResult();
        }

        // This method is the same as in LazyArgumentValidation;
        // only ComputeLengthAsync is different.
        static async Task MainAsync()
        {
            Task<int> task = ComputeLengthAsync(null);
            Console.WriteLine("Fetched the task");
            int length = await task;
            Console.WriteLine("Length: {0}", length);
        }

        static Task<int> ComputeLengthAsync(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }
            return ComputeLengthAsyncImpl(text);
        }

        static async Task<int> ComputeLengthAsyncImpl(string text)
        {
            await Task.Delay(500);
            return text.Length;
        }
    }
}
