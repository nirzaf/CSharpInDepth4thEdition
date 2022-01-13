using System;

namespace Chapter13
{
    public struct YearMonthDay
    {
        public int Year { get; }
        public int Month { get; }
        public int Day { get; }

        public YearMonthDay(int year, int month, int day) =>
            (Year, Month, Day) = (year, month, day);
    }

    public readonly struct ReadOnlyYearMonthDay
    {
        public int X
        {
            get => 0;
            set => Console.WriteLine(value);
        }

        public int Year { get; }
        public int Month { get; }
        public int Day { get; }

        public ReadOnlyYearMonthDay(int year, int month, int day) =>
            (Year, Month, Day) = (year, month, day);
    }
}
