using System;
using System.ComponentModel;

namespace Chapter10
{
    [Description("Listing 10.13")]
    class FirstExceptionFilter
    {
        static void Main()
        {
            string[] messages =
            {
                "You can catch this",
                "You can catch this too",
                "This won't be caught"
            };
            foreach (string message in messages)
            {
                try
                {
                    throw new Exception(message);
                }
                catch (Exception e) when (e.Message.Contains("catch"))
                {
                    Console.WriteLine($"Caught '{e.Message}'");
                }
            }
        }
    }
}
