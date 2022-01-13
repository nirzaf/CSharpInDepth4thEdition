using System;
using System.ComponentModel;
using System.IO;
#pragma warning disable CS0168 // Variable is declared but never used

namespace Chapter10
{
    [Description("Listing 10.14")]
    class ThreeLevelException
    {
        static bool LogAndReturn(string message, bool result)
        {
            Console.WriteLine(message);
            return result;
        }

        static void Top()
        {
            try
            {
                throw new Exception();
            }
            finally
            {
                Console.WriteLine("Top finally");
            }
        }

        static void Middle()
        {
            try
            {
                Top();
            }
            catch (Exception e) when (LogAndReturn("Middle filter", false))
            {
                Console.WriteLine("Caught in middle");
            }
            finally
            {
                Console.WriteLine("Middle finally");
            }
        }

        static void Bottom()
        {
            try
            {
                Middle();
            }
            catch (IOException e) when (LogAndReturn("Never called", true))
            {
            }
            catch (Exception e) when (LogAndReturn("Bottom filter", true))
            {
                Console.WriteLine("Caught in Bottom");
            }
        }

        static void Main()
        {
            Bottom();
        }
    }
}
#pragma warning restore CS0168 // Variable is declared but never used
