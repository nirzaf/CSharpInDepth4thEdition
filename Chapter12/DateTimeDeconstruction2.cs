using System;
using System.ComponentModel;

namespace Chapter12
{
    [Description("Listing 12.9")]
    static class DateTimeDeconstruction2
    {
        static void Deconstruct(
            this DateTime dateTime,
            out int year, out int month, out int day) =>
            (year, month, day) = (dateTime.Year, dateTime.Month, dateTime.Day);

        static void Deconstruct(
            this DateTime dateTime,
            out int year, out int month, out int day,
            out int hour, out int minute, out int second) =>
            (year, month, day, hour, minute, second) = 
            (dateTime.Year, dateTime.Month, dateTime.Day,
            dateTime.Hour, dateTime.Minute, dateTime.Second);

        static void Main()
        {
            DateTime birthday = new DateTime(1976, 6, 19);
            DateTime now = DateTime.UtcNow;

            var (year, month, day, hour, minute, second) = now;
            (year, month, day) = birthday;
        }
    }
}
