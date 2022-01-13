using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10.Extensions
{
    public static class DictionaryExtensions
    {
        public static void Add<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            TKey key, TValue value)
        {
            dictionary.Add(key, value);
        }
    }
}

namespace Chapter10
{
    using System.ComponentModel;
    using static Chapter10.Extensions.DictionaryExtensions;

    [Description("Listing 10.11")]
    class ConcurrentDictionaryCollectionInitializer
    {
        static void Main()
        {
            var dictionary = new ConcurrentDictionary<string, int>
            {
                { "x", 10 },
                { "y", 20 }
            };
        }
    }
}
