using Microsoft.Office.Interop.Word;
using System.ComponentModel;

namespace Chapter04Com
{
    [Description("Listing 4.17")]
    class SaveFileNew
    {
        static void Main()
        {
            Application app = new Application { Visible = true };
            Document doc = app.Documents.Add();
            Paragraph para = doc.Paragraphs.Add();
            para.Range.Text = "Simple new code";

            doc.SaveAs2(FileName: "demo2.docx");

            doc.Close();
            app.Application.Quit();
        }
    }
}
