using System;

namespace Chapter14
{
    [AttributeUsage(AttributeTargets.Field)]
    class DemoAttribute : Attribute
    {
    }

    class FieldAttributes
    {
        [field: Demo]
        public static int Value { get; set; }

        [field: Demo]
        public static event EventHandler Foo;
    }
}
