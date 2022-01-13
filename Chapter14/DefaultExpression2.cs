using System;

namespace Chapter14
{
    class DefaultExpression2
    {
        static void Main()
        {
            var intArray = new[] { default, 5 };
            var stringArray = new[] { default, "text" };
            var boolArray = new[] { default, true };

            Console.WriteLine(intArray[0]);
            Console.WriteLine(stringArray[0] == null);
            Console.WriteLine(boolArray[0]);
        }
    }
}
