using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Chapter10
{
    public static class StringListExtensions
    {
        public static void Add(this List<string> list, int value, int count = 1)
        {
            list.AddRange(Enumerable.Repeat(value.ToString(), count));
        }
    }

    [Description("Listing 10.9")]
    class CollectionInitializerExtensionMethods
    {
        static void Main()
        {
            List<string> strings = new List<string>
            {
              10,
              "hello",
              { 20, 3 }
            };
            Console.WriteLine(strings.Count);
        }
    }
}
