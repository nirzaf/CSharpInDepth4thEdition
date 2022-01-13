using System;
using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.8")]
    class RefReturnIndexer
    {
        class ArrayHolder
        {
            private readonly int[] array = new int[10];

            public ref int this[int index] => ref array[index];
        }

        static void Main()
        {
            ArrayHolder holder = new ArrayHolder();
            ref int x = ref holder[0];
            ref int y = ref holder[0];

            x = 20;
            Console.WriteLine(y);
        }
    }
}
