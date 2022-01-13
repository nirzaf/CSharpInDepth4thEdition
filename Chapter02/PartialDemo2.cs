using System;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.23")]
    class PartialDemo2
    {
        partial class PartialMethodsDemo
        {
            public PartialMethodsDemo()
            {
                OnConstruction();
            }

            public override string ToString()
            {
                string ret = "Original return value";
                CustomizeToString(ref ret);
                return ret;
            }

            partial void OnConstruction();
            partial void CustomizeToString(ref string text);
        }

        partial class PartialMethodsDemo
        {
            partial void CustomizeToString(ref string text)
            {
                text += " - customized!";
            }
        }

        static void Main()
        {
            PartialMethodsDemo demo = new PartialMethodsDemo();
            string text = demo.ToString();
            Console.WriteLine(text);
        }
    }
}
