using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.7")]
    class TypeOfExample
    {
        static void PrintType<T>()
        {
            Console.WriteLine("typeof(T) = {0}", typeof(T));
            Console.WriteLine("typeof(List<T>) = {0}", typeof(List<T>));
        }

        static void Main()
        {
            PrintType<string>();
            PrintType<int>();
        }
    }
}
