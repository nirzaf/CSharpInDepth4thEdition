using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter07
{
    [Description("Listing 7.7")]
    class CallerInfoConstructors
    {
        public abstract class BaseClass
        {
            protected BaseClass(
                [CallerFilePath] string file = "Unspecified file",
                [CallerLineNumber] int line = -1,
                [CallerMemberName] string member = "Unspecified member")
            {
                Console.WriteLine("{0}:{1} - {2}", file, line, member);
            }
        }

        public class Derived1 : BaseClass { }

        public class Derived2 : BaseClass
        {
            internal Derived2() { }
        }

        public class Derived3 : BaseClass
        {
            internal Derived3() : base() {}
        }

        static void Main()
        {
            var d1 = new Derived1();
            var d2 = new Derived2();
            var d3 = new Derived3();
        }
    }
}
