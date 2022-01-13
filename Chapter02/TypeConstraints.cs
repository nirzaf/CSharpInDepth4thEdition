using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Chapter02
{
    public class TypeConstraints
    {
        static void PrintItems<T>(List<T> items) where T : IFormattable
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            foreach (T item in items)
            {
                Console.WriteLine(item.ToString(null, culture));
            }
        }

        static void Main()
        {
            List<decimal> items = new List<decimal>();
            items.Add(1.5m);
            items.Add(2.3m);
            PrintItems(items);
        }
    }
}
