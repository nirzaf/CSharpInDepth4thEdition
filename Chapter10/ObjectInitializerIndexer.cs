using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    [Description("Listing 10.5")]
    class ObjectInitializerIndexer
    {
        static void Main()
        {
            string text = "This text needs truncating";
            StringBuilder builder = new StringBuilder(text)
            {
                Length = 10,
                [9] = '\u2026'
            };
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(builder);
        }
    }
}
