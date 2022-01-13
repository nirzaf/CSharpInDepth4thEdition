using System;
using System.ComponentModel;

namespace Chapter13
{
    class ReadOnlyArrayView<T>
    {
        private readonly T[] values;

        public ReadOnlyArrayView(T[] values) => this.values = values;

        public ref readonly T this[int index] => ref values[index];
    }

    [Description("Listing 13.11")]
    class ReadOnlyArrayViewDemo
    {
        static void Main()
        {
            var array = new int[] { 10, 20, 30 };
            var view = new ReadOnlyArrayView<int>(array);

            ref readonly int element = ref view[0];
            Console.WriteLine(element);
            array[0] = 100;
            Console.WriteLine(element);
        }
    }
}
