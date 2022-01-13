using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter04
{
    [Description("Listing 4.13")]
    class DynamicTypingAndExplicitInterfaceImplementation
    {
        static void Main()
        {
            List<int> list1 = new List<int>();
            //Console.WriteLine(list1.IsFixedSize);

            IList list2 = list1;
            Console.WriteLine(list2.IsFixedSize);

            dynamic list3 = list1;
            Console.WriteLine(list3.IsFixedSize);
        }
    }
}
