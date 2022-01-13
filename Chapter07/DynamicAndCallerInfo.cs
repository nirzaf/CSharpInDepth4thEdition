using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter07
{
    [Description("Listing 7.6")]
    class DynamicAndCallerInfo
    {
        static void ShowLine(string message, [CallerLineNumber] int line = 0)
        {
            Console.WriteLine("{0}: {1}", line, message);
        }

        static int GetLineNumber([CallerLineNumber] int line = 0)
        {
            return line;
        }

        static void Main()
        {
            dynamic message = "Some message";
            ShowLine(message);
            ShowLine((string) message);
            ShowLine(message, GetLineNumber());
        }
    }
}
