using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;

namespace Chapter04
{
    [Description("Listing 4.5")]
    class ExpandoObjectIntroduction
    {
        static void Main()
        {
            dynamic expando = new ExpandoObject();
            expando.SomeData = "Some data";
            Action<string> action = input => Console.WriteLine("The input was '{0}'", input);
            expando.FakeMethod = action;

            Console.WriteLine(expando.SomeData);
            expando.FakeMethod("hello");

            IDictionary<string, object> dictionary = expando;
            Console.WriteLine("Keys: {0}", string.Join(", ", dictionary.Keys));

            dictionary["OtherData"] = "other";
            Console.WriteLine(expando.OtherData);
        }
    }
}
