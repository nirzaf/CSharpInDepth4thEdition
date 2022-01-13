using System;
using System.ComponentModel;

namespace Chapter14
{
    [Description("Listing 14.4")]
    class LocalMethodVariableCapture2
    {
        static void Main()
        {
            DateTime now = DateTime.UtcNow;
            int hour = now.Hour;
            if (hour > 5)
            {
                int minute = now.Minute;
                PrintHourAndMinute();

                void PrintHourAndMinute() =>
                    Console.WriteLine($"hour = {hour}; minute = {minute}");
            }
        }
    }
}
