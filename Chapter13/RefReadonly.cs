using System;
using System.ComponentModel;

namespace Chapter13
{
    [Description("Listing 13.10")]
    class RefReadonly
    {
        private static readonly int field = DateTime.UtcNow.Second;

        static ref readonly int GetFieldAlias() => ref field;

        static void Main()
        {
            ref readonly int local = ref GetFieldAlias();
            Console.WriteLine(local);
        }
    }
}
