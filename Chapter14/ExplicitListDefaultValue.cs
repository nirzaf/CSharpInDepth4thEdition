using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter14
{
    class ExplicitListDefaultValue
    {
        static void Main()
        {
            var list = new List<int> { 5, 2, 1 };
            Console.WriteLine(GetValueOrDefault(list, 1));
            Console.WriteLine(GetValueOrDefault(list, 10));
        }

        static T GetValueOrDefault<T>(IList<T> list, int index)
        {
            return index >= 0 && index < list.Count ? list[index] : default(T);
        }
    }
}
