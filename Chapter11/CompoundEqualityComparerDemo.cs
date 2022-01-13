using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter11
{
    class CompoundEqualityComparerDemo
    {
        static void Main()
        {
            var comparer = new CompoundEqualityComparer();
            comparer.Add(new AbsoluteValueEqualityComparer());
            comparer.Add(StringComparer.OrdinalIgnoreCase);

            IStructuralEquatable a = ("abc", 10, 'x');
            IStructuralEquatable b = ("ABC", 10, 'x');
            IStructuralEquatable c = ("abc", -10, 'x');
            IStructuralEquatable d = ("abc", 10, 'X');
            IStructuralEquatable e = ("def", 10, 'x');
            IStructuralEquatable f = ("abc", 20, 'x');
            IStructuralEquatable g = ("abc", 10, 'y');

            Console.WriteLine(a.Equals(b, comparer)); // True: string comparisons are case-insensitive
            Console.WriteLine(a.Equals(c, comparer)); // True: int comparisons are sign-insensitive
            Console.WriteLine(a.Equals(d, comparer)); // False: char comparisons are case-sensitive
            Console.WriteLine(a.Equals(e, comparer)); // False: we don't just ignore the string value
            Console.WriteLine(a.Equals(f, comparer)); // False: we don't just ignore the int value
            Console.WriteLine(a.Equals(g, comparer)); // False: we don't just ignore the char value
        }

        private class AbsoluteValueEqualityComparer : IEqualityComparer<int>
        {
            // Our GetHashCode implementation never gives the same results for
            // non-equal values, handily.
            public bool Equals(int x, int y) => GetHashCode(x) == GetHashCode(y);

            // We don't return the absolute value: we return the *negative* of the absolute
            // value, as that allows us to handle int.MinValue easily.
            public int GetHashCode(int obj) => obj > 0 ? -obj : obj;
        }
    }
}
