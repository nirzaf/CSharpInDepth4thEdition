using System;
using System.ComponentModel;

namespace Chapter12
{
    [Description("Listing 12.14")]
    class TypePatternWithNullableType
    {
        static void Main()
        {
            CheckType<int?>(null);
            CheckType<int?>(5);
            CheckType<int?>("text");
            CheckType<string>(null);
            CheckType<string>(5);
            CheckType<string>("text");
        }

        static void CheckType<T>(object value)
        {
            if (value is T t)
            {
                Console.WriteLine($"Yes! {t} is a {typeof(T)}");
            }
            else
            {
                Console.WriteLine($"No! {value ?? "null"} is not a {typeof(T)}");
            }
        }
    }
}
