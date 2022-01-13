using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter07
{
    [Description("Listing 7.3")]
    class CallerInfoDemo
    {
        static void ShowInfo(
            [CallerFilePath] string file = null,
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = null)
        {
            Console.WriteLine("{0}:{1} - {2}", file, line, member);
        }

        static void Main()
        {
            ShowInfo();
            ShowInfo("LiesAndDamnedLies.java", -10);
        }
    }
}
