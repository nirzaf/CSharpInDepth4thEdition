using System;
using System.ComponentModel;
using GuidAlias = System.Guid;

namespace Chapter09
{
    [Description("Listing 9.17")]
    class NameofWithAlias
    {
        static void Main()
        {
            Console.WriteLine(nameof(GuidAlias));
        }
    }
}
