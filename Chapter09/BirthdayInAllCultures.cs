using System;
using System.ComponentModel;
using System.Globalization;

namespace Chapter09
{
    [Description("Listing 9.2")]
    class BirthdayInAllCultures
    {
        static void Main()
        {
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            var birthDate = new DateTime(1976, 6, 19);
            foreach (var culture in cultures)
            {
                string text = string.Format(culture, "{0,-15} {1,12:d}", culture.Name, birthDate);
                Console.WriteLine(text);
            }
        }
    }
}
