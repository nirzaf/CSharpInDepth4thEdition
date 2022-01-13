using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chapter02
{
    [Description("Listing 2.24")]
    class StaticClasses
    {
        static class StaticClassDemo
        {
            public static void StaticMethod() { }

            //public void InstanceMethod() { }

            public class RegularNestedClass
            {
                public void InstanceMethod() { }
            }
        }

        static void Main()
        {
            StaticClassDemo.StaticMethod();

            //StaticClassDemo localVariable = null;
            //List<StaticClassDemo> list = new List<StaticClassDemo>();
        }
    }
}
