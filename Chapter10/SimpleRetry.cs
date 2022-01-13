using System;
using System.ComponentModel;
using System.Threading;

namespace Chapter10
{
    [Description("Listing 10.15")]
    class SimpleRetry
    {
        static T Retry<T>(Func<T> operation, int attempts)
        {
            while (true)
            {
                try
                {
                    attempts--;
                    return operation();
                }
                catch (Exception e) when (attempts > 0)
                {
                    Console.WriteLine($"Failed: {e}");
                    Console.WriteLine($"Attempts left: {attempts}");
                    Thread.Sleep(5000);
                }
            }
        }

        static void Main()
        {
            Func<DateTime> temporamentalCall = () =>
            {
                DateTime utcNow = DateTime.UtcNow;
                if (utcNow.Second < 20)
                {
                    throw new Exception("I don't like the start of a minute");
                }
                return utcNow;
            };

            var result = Retry(temporamentalCall, 3);
            Console.WriteLine(result);
        }
    }
}
