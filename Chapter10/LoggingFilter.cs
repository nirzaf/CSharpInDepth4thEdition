using System;
using System.ComponentModel;

namespace Chapter10
{
    [Description("Listing 10.16")]
    class LoggingFilter
    {
        static void Main()
        {
            try
            {
                UnreliableMethod();
            }
            catch (Exception e) when (Log(e))
            {
            }
        }        

        static void UnreliableMethod()
        {
            throw new Exception("Bang!");
        }

        static bool Log(Exception e)
        {
            Console.WriteLine($"{DateTime.UtcNow}: {e.GetType()} {e.Message}");
            return false;
        }
    }
}
