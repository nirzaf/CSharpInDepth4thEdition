using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter13
{
    class NoParameterCopy
    {
        public void PrintYearMonthDay(YearMonthDay input)
        {
            int year = input.Year;
            int month = input.Month;
            int day = input.Day;
            Console.WriteLine($"{year} {month} {day}");
        }
    }
}
