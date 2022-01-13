using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter11
{
    // Note: this implementation is only a sketch.
    // It relies on the execution-time type of the value being hashed
    // or the first of the values being compared for equality being the
    // exact type of comparer registered - if you register an EqualityComparer for
    // Control, it won't find it if you pass in a Button, for example.
    // A fuller implementation - with handling of comparers of interfaces and the like
    // - is beyond the scope of the sample code.
    public sealed class CompoundEqualityComparer : IEqualityComparer
    {
        private readonly Dictionary<Type, Func<object, object, bool>> equaters
            = new Dictionary<Type, Func<object, object, bool>>();
        private readonly Dictionary<Type, Func<object, int>> hashers
            = new Dictionary<Type, Func<object, int>>();

        /// <summary>
        /// Adds a specific comparer to this compound comparer.
        /// </summary>
        /// <typeparam name="T">The type of the elements to compare</typeparam>
        /// <param name="comparer">The comparer to use for those elements. Must not be null.</param>
        public void Add<T>(IEqualityComparer<T> comparer)
        {
            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            equaters.Add(typeof(T), (x, y) => comparer.Equals((T)x, (T)y));
            hashers.Add(typeof(T), x => comparer.GetHashCode((T)x));
        }

        public new bool Equals(object x, object y)
        {
            if (x == y)
            {
                return true;
            }
            if (x == null || y == null)
            {
                return false;
            }
            Func<object, object, bool> equater;
            return equaters.TryGetValue(x.GetType(), out equater)
                ? equater(x, y) : x.Equals(y);
        }

        public int GetHashCode(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            Func<object, int> hasher;
            return hashers.TryGetValue(obj.GetType(), out hasher)
                ? hasher(obj) : obj.GetHashCode();
        }
    }
}
