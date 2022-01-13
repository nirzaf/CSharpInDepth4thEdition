using System;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.9")]
    class NullableBoxing
    {
        static void Main()
        {
            Nullable<int> noValue = new Nullable<int>();
            object noValueBoxed = noValue;
            Console.WriteLine(noValueBoxed == null);

            Nullable<int> someValue = new Nullable<int>(5);
            object someValueBoxed = someValue;
            Console.WriteLine(someValueBoxed.GetType());
        }
    }
}
