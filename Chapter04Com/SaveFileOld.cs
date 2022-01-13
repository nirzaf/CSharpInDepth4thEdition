using Microsoft.Office.Interop.Word;
using System;
using System.ComponentModel;

namespace Chapter04Com
{
    [Description("Listing 4.16")]
    class SaveFileOld
    {
        static void Main()
        {
            object missing = Type.Missing;

            Application app = new Application { Visible = true };
            Document doc = app.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            Paragraph para = doc.Paragraphs.Add(ref missing);
            para.Range.Text = "Awkward old code";

            object fileName = "demo1.docx";
            doc.SaveAs2(ref fileName, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing);

            doc.Close(ref missing, ref missing, ref missing);
            app.Application.Quit(ref missing, ref missing, ref missing);
        }
    }
}
