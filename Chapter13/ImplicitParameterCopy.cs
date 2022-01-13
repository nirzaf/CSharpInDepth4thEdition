using System;

namespace Chapter13
{
    class ImplicitParameterCopy
    {
        // No copying for each property; the parameter is already a copy of the caller's value.
        public void PrintYearMonthDay(YearMonthDay input) =>
            Console.WriteLine($"{input.Year} {input.Month} {input.Day}");

        // Implicit copy for each property.
        public void PrintYearMonthDay(in YearMonthDay input) =>
            Console.WriteLine($"{input.Year} {input.Month} {input.Day}");

        // No value copying at all!
        public void PrintYearMonthDay(in ReadOnlyYearMonthDay input) =>
            Console.WriteLine($"{input.Year} {input.Month} {input.Day}");
    }
}
