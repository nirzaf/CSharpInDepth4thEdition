using System;
using System.ComponentModel;

namespace Chapter12
{
    [Description("Snippet in section 10.1.3")]
    class TupleLiteralDeconstruction
    {
        static void Main()
        {
            (string text, Func<int, int> func) = (null, x => x * 2);
            (text, func) = ("text", x => x * 3);
        }
    }
}
