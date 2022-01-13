using System;
using System.ComponentModel;

namespace Chapter02
{
    [Description("Listing 2.1")]
    public class NamesWithArray
    {
        static string[] GenerateNames()
        {
            string[] names = new string[4];
            names[0] = "Gamma";
            names[1] = "Vlissides";
            names[2] = "Johnson";
            names[3] = "Helm";
            return names;
        }

        static void PrintNames(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void Main()
        {
            string[] names = GenerateNames();
            PrintNames(names);
        }
    }
}
