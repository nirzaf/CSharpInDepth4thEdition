using System;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.22")]
    class PartialDemo1
    {
        partial class PartialDemo
        {
            public static void MethodInPart1()
            {
                MethodInPart2();
            }
        }

        partial class PartialDemo
        {
            private static void MethodInPart2()
            {
                Console.WriteLine("In MethodInPart2");
            }
        }

        static void Main()
        {
            PartialDemo.MethodInPart1();
        }
    }
}
