using System;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.10")]
    class NullableGetType
    {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        static void Main()
        {
            Nullable<int> noValue = new Nullable<int>();
                              // Console.WriteLine(noValue.GetType());

            Nullable<int> someValue = new Nullable<int>(5);
            Console.WriteLine(someValue.GetType());
        }
#pragma warning restore CS0219 // Variable is assigned but its value is never used
    }
}
