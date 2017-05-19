﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using NUnit.Framework.Interfaces;
using TRID.ProjectLibs;
using TRID.ProjectLibs.Common;
using Excel = Microsoft.Office.Interop.Excel;

namespace TRID.CommonUtils
{
    public class GetExcelData : TridVariable
    {
        private static string FilePath => ConfigurationManager.AppSettings["ExcelFilePath"];

        // Get Excel sheet all cell values
        public void GetExcelValues(int rowNumber, string sheetName)
        {
            var xApplication = new Excel.Application();
            xApplication.DisplayAlerts = false;
            var xWorkbook = xApplication.Workbooks.Open(FilePath, Notify: false);
            Excel.Worksheet xWorksheet = xWorkbook.Sheets[sheetName];
            var xRange = xWorksheet.UsedRange;
            var cellValue = "";
            var columnNumber = 0;
            var colCount = xRange.Columns.Count;
            for (columnNumber = 1; columnNumber <= colCount; columnNumber++)
                if (xRange.Cells[rowNumber, columnNumber] != null && xRange.Cells[rowNumber, columnNumber].Value2 != null)
                {
                    cellValue = xRange.Cells[rowNumber, columnNumber].Value2.ToString();
                    GetVariableNameAndSetValues(rowNumber, columnNumber, cellValue, sheetName);
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
        }
    }
}
