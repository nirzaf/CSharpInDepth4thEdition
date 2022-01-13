using Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.Linq;

namespace Chapter04Com
{
    [Description("Listing 4.15")]
    class ExcelDynamic
    {
        static void Main()
        {
            var app = new Application { Visible = true };
            app.Workbooks.Add();
            Worksheet sheet = app.ActiveSheet;
            Range start = sheet.Cells[1, 1];
            Range end = sheet.Cells[1, 20];
            sheet.Range[start, end].Value =
                Enumerable.Range(1, 20).ToArray();
        }
    }
}
