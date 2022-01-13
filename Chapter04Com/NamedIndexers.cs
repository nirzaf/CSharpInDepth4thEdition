using Microsoft.Office.Interop.Word;
using System;
using System.ComponentModel;

namespace Chapter04Com
{
    [Description("Listing 4.18")]
    class NamedIndexers
    {
        static void Main()
        {
            Application app = new Application { Visible = false };

            object missing = Type.Missing;
            SynonymInfo info = app.get_SynonymInfo("method", ref missing);
            Console.WriteLine("'method' has {0} meanings", info.MeaningCount);

            info = app.SynonymInfo["index"];
            Console.WriteLine("'index' has {0} meanings", info.MeaningCount);
        }
    }
}
