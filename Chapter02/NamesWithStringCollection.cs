using System;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.3")]
    public class NamesWithStringCollection
    {
        static StringCollection GenerateNames()
        {
            StringCollection names = new StringCollection();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }

        static void PrintNames(StringCollection names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void Main()
        {
            StringCollection names = GenerateNames();
            PrintNames(names);
        }
    }
}
