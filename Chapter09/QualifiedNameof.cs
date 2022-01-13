using System;
using System.ComponentModel;

namespace Chapter09
{
    class OtherClass
    {
        public static int StaticMember => 3;
        public int InstanceMember => 3;
    }

    [Description("Listing 9.16")]
    class QualifiedNameof
    {
        static void Main()
        {
            OtherClass instance = null;
            Console.WriteLine(nameof(instance.InstanceMember));
            Console.WriteLine(nameof(OtherClass.StaticMember));
            Console.WriteLine(nameof(OtherClass.InstanceMember));
        }
    }
}
