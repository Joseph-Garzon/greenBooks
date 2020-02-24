using System;
using System.Collections.Generic;
using System.Text;

using _Excel = Microsoft.Office.Interop.Excel;
namespace greenBooks
{
    
    class Excelr
    {
        string path = "";
        _Excel._Application excel = new _Excel.Application();
        _Excel.Workbook wb;
        _Excel.Worksheet ws;

        public Excelr(string path, int sheet)
        {
            this.path = path;
            wb = (Microsoft.Office.Interop.Excel.Workbook)excel.Workbooks.Open(@"C:\Users\OTHSCS120\Dropbox\greenBooks\greenBooks\ggez.xlsx");
            ws = (_Excel.Worksheet)wb.Worksheets[sheet];
        }
        public string readCell(int i, int j)
        {
            if (((Microsoft.Office.Interop.Excel.Range)ws.Cells[i, j]).Value.ToString() != null)
                return ((Microsoft.Office.Interop.Excel.Range)ws.Cells[i, j]).Value.ToString();
            else
                return null;
        }
    }

}
