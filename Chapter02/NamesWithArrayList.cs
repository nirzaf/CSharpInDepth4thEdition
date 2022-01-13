using System;
using System.Collections;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.2")]
    public class NamesWithArrayList
    {
        static ArrayList GenerateNames()
        {
            ArrayList names = new ArrayList();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }

        static void PrintNames(ArrayList names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void Main()
        {
            ArrayList names = GenerateNames();
            PrintNames(names);
        }
    }
}
