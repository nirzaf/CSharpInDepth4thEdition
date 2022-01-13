using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter04
{
    class MixedDynamicAndStaticOverloadResolution
    {
        static void Method(int x, string y)
        {
            Console.WriteLine("int, string");
        }

        static void Method(int x, object y)
        {
            Console.WriteLine("int, object");
        }

        static void Method(object x, object y)
        {
            Console.WriteLine("object, object");
        }

        static void Main()
        {
            dynamic arg1 = 10;
            object arg2 = "text";
            // This calls the second overload - the "int, object" method.
            // - The first overload isn't applicable because the *compile-time* type of arg2 is
            //   used. Even though this is a dynamically-bound call, the second argument has a
            //   static type of "object", so that's used in overload resolution.
            // - The third overload isn't used because the second overload is more specific:
            //   the execution-time type of arg1 is used because it's dynamic.
            Method(arg1, arg2);
        }
    }
}
