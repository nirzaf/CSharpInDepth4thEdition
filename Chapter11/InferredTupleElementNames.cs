using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter11
{
    class InferredTupleElementNames
    {
        static void Main()
        {
            List<int> list = new List<int> { 5, 1, -6, 2 };
            var tuple = (list.Count, Min: list.Min(), Max: list.Max());
            Console.WriteLine(tuple.Count);
            Console.WriteLine(tuple.Min);
            Console.WriteLine(tuple.Max);
        }
    }
}
