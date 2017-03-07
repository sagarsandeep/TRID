using System;
using System.Configuration;
using System.Runtime.InteropServices;
using TRID.ProjectLibs;
using TRID.ProjectLibs.Common;
using Excel = Microsoft.Office.Interop.Excel;

namespace TRID.CommonUtils
{
    public class GetExcelData : TridVariable
    {
        private static string FilePath => ConfigurationManager.AppSettings["ExcelFilePath"];

        public string GetExcelCellValues(string sheetName, int row, int col)
        {
            Excel.Application xApplication = new Excel.Application();
            Excel.Workbook xWorkbook = xApplication.Workbooks.Open(FilePath);
            Excel.Worksheet xWorksheet = xWorkbook.Sheets[sheetName];
            Excel.Range xRange = xWorksheet.UsedRange;
            var data = xRange.Cells[row, col].Value2.ToString();
            
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xRange);
            Marshal.ReleaseComObject(xWorksheet);

            //close and release
            xWorkbook.Close();
            Marshal.ReleaseComObject(xWorkbook);

            //quit and release
            xApplication.Quit();
            Marshal.ReleaseComObject(xApplication);

            return data;
        }

        public string GetExcelValues(int scenarioNo, string sheetName)
        {
            var xApplication = new Excel.Application();
            var xWorkbook = xApplication.Workbooks.Open(FilePath);
            Excel.Worksheet xWorksheet = xWorkbook.Sheets[sheetName];
            var xRange = xWorksheet.UsedRange;
            var data = "";
            var colCount = xRange.Columns.Count;

            for (var row = scenarioNo + 1; row == scenarioNo + 1; row++)
            for (var col = 1; col <= colCount; col++)
                if (xRange.Cells[row, col] != null && xRange.Cells[row, col].Value2 != null)
                {
                    data = xRange.Cells[row, col].Value2.ToString();
                    GetVariableNameAndSetValues(row, col, data, sheetName);
                }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xRange);
            Marshal.ReleaseComObject(xWorksheet);

            //close and release
            xWorkbook.Close();
            Marshal.ReleaseComObject(xWorkbook);

            //quit and release
            xApplication.Quit();
            Marshal.ReleaseComObject(xApplication);

            return data;
        }
    }
}
