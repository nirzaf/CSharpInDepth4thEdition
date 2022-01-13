using System;
using System.ComponentModel;

namespace Chapter09
{
    [Description("Listing 9.11")]
    class EagerEvaluation
    {
        static void Main()
        {
            string value = "Before";
            FormattableString formattable = $"Current value: {value}";
            Console.WriteLine(formattable);

            value = "After";
            Console.WriteLine(formattable);
        }
    }
}
