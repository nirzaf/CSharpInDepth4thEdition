using System;
using System.Runtime.CompilerServices;

namespace Chapter07
{
    class CallerNameCornerCases
    {
        static void ShowCallerName(string manualCaller, [CallerMemberName] string name = "(unspecified)")
        {
            Console.WriteLine("From {0}, compiler provided: {1}", manualCaller, name);
        }

        ~CallerNameCornerCases()
        {
            ShowCallerName("finalizer");
        }

        CallerNameCornerCases()
        {
            ShowCallerName("constructor");
        }

        public int this[int x]
        {
            get
            {
                ShowCallerName("indexer");
                return 10;
            }
        }

        public static implicit operator string(CallerNameCornerCases x)
        {
            ShowCallerName("conversion");
            return "";
        }        

        public static CallerNameCornerCases operator +(CallerNameCornerCases lhs, int rhs)
        {
            ShowCallerName("operator");
            return lhs;
        }        

        static void Main()
        {
            var tmp = new CallerNameCornerCases();
            tmp = tmp + 1;
            int xy = tmp[20];
            string y = tmp;
            tmp = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
