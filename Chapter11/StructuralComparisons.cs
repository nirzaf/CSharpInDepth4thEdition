using System;
using System.Collections;
using System.ComponentModel;

namespace Chapter11
{
    [Description("Listing 11.10")]
    class StructuralComparisons
    {
        static void Main()
        {
            var Ab = ("A", "b");
            var aB = ("a", "B");
            var aa = ("a", "a");
            var ba = ("b", "a");

            Compare(Ab, aB);
            Compare(aB, aa);
            Compare(aB, ba);
        }

        static void Compare<T>(T x, T y)
            where T : IStructuralEquatable, IStructuralComparable
        {
            var comparison = x.CompareTo(y, StringComparer.OrdinalIgnoreCase);
            var equal = x.Equals(y, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(
                $"{x} and {y} - comparison: {comparison}; equal: {equal}");
        }
    }
}
