using System;
using System.ComponentModel;
using System.Globalization;
using static System.FormattableString;

namespace Chapter09
{
    [Description("Listing 9.6")]
    class FormatDateInvariant
    {
        static void Main()
        {
            DateTime date = DateTime.UtcNow;

            string parameter1 = string.Format(
                CultureInfo.InvariantCulture,
                "x={0:yyyy-MM-dd}",
                date);

            string parameter2 = 
                ((FormattableString)$"x={date:yyyy-MM-dd}")
                .ToString(CultureInfo.InvariantCulture);

            string parameter3 =
                FormattableString.Invariant($"x={date:yyyy-MM-dd}");

            string parameter4 = Invariant($"x={date:yyyy-MM-dd}");
        }
    }
}
