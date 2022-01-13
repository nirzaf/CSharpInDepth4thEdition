using System;
using System.ComponentModel;

namespace Chapter04
{
    [Description("Listing 4.1")]
    class DynamicTypingIntro
    {
        static void Main()
        {
            dynamic text = "hello world";
            string world = text.Substring(6);
            Console.WriteLine(world);

            string broken = text.SUBSTR(6);
            Console.WriteLine(broken);
        }
    }
}
