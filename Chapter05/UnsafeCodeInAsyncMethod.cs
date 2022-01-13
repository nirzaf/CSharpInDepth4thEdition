using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Chapter05
{
    [Description("Listing 5.3")]
    class UnsafeCodeInAsyncMethod
    {
        static void Main()
        {
            DelayWithResultOfUnsafeCode("Some text").GetAwaiter().GetResult();
        }

        static async Task DelayWithResultOfUnsafeCode(string text)
        {
            int total = 0;
            unsafe
            {
                fixed (char* textPointer = text)
                {
                    char* p = textPointer;
                    while (*p != 0)
                    {
                        total += *p;
                        p++;
                    }
                }
            }
            Console.WriteLine("Delaying for " + total + "ms");
            await Task.Delay(total);
            Console.WriteLine("Delay complete");
        }
    }
}
