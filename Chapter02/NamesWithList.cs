using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.4")]
    public class NamesWithList
    {
        static List<string> GenerateNames()
        {
            List<string> names = new List<string>();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }

        static void PrintNames(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void Main()
        {
            List<string> names = GenerateNames();
            PrintNames(names);
        }
    }
}
