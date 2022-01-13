using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter05
{
    [Description("Listing 5.6c (local method)")]
    class EagerArgumentValidation3
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
                // If we can use local methods, we can definitely use nameof...
                throw new ArgumentNullException(nameof(text));
            }
            return Impl(text);

            // This could be a parameterless method, but by passing the
            // value in rather than capturing it, the compiler can optimize more.
            async Task<int> Impl(string t)
            {
                await Task.Delay(500);
                return t.Length;
            }
        }
    }
}
