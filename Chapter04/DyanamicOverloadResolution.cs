using System;
using System.ComponentModel;

namespace Chapter04
{
    [Description("Listing 4.3")]
    class DyanamicOverloadResolution
    {
        static void SampleMethod(int value)
        {
            Console.WriteLine("Method with int parameter");
        }

        static void SampleMethod(decimal value)
        {
            Console.WriteLine("Method with decimal parameter");
        }

        static void SampleMethod(object value)
        {
            Console.WriteLine("Method with object parameter");
        }

        static void CallMethod(dynamic d)
        {
            SampleMethod(d);
        }

        static void Main()
        {
            CallMethod(10);
            CallMethod(10.5m);
            CallMethod(10L);
            CallMethod("text");
        }
    }
}
