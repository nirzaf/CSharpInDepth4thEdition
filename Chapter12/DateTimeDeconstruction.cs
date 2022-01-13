using System;
using System.ComponentModel;

namespace Chapter12
{
    [Description("Listing 12.8")]
    static class DateTimeDeconstruction
    {
        static void Deconstruct(
            this DateTime dateTime,
            out int year, out int month, out int day) =>
            (year, month, day) = (dateTime.Year, dateTime.Month, dateTime.Day);

        static void Main()
        {
            DateTime now = DateTime.UtcNow;
            var (year, month, day) = now;
            Console.WriteLine($"{year:0000}-{month:00}-{day:00}");
        }
    }
}
