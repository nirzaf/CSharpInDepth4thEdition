using System;
using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.4")]
    class RefLocalField
    {
        private int value;

        static void Main()
        {
            var obj = new RefLocalField();
            ref int tmp = ref obj.value;
            tmp = 10;
            Console.WriteLine(obj.value);

            obj = new RefLocalField();
            Console.WriteLine(tmp);
            Console.WriteLine(obj.value);
        }
    }
}
