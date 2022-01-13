using System;
using System.ComponentModel;
using System.Globalization;

namespace Chapter13
{
    [Description("Listing 13.12")]
    class InParameterOptions
    {
        static void PrintDateTime(in DateTime value)
        {
            string text = value.ToString(
                "yyyy-MM-dd'T'HH:mm:ss",
                CultureInfo.InvariantCulture);
            Console.WriteLine(text);
        }

        static void Main()
        {
            DateTime start = DateTime.UtcNow;
            PrintDateTime(start);
            PrintDateTime(in start);
            PrintDateTime(start.AddMinutes(1));
            //PrintDateTime(in start.AddMinutes(1));
        }
    }
}
