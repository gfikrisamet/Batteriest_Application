using OfficeOpenXml;
using System;
using System.Drawing;
using System.IO;


namespace Batteriest
{
    public class Excel
    {
        public static int fileCounter = 1;
        public static string SelectedFileNameWithoutExtension = "BatteriestTest";
        public static string SelectedExtension = ".xlsx";
        public static string SelectedFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), string.Format(SelectedFileNameWithoutExtension + fileCounter + SelectedExtension));
        public static string SelectedDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static bool StartSavingExcel = false;
        public static bool Reset = false;

        public static string ExcelBrowse = SelectedFilePath;

        public static FileInfo fileInfo = new FileInfo(ExcelBrowse);
        public static ExcelPackage excelPackage = new ExcelPackage();
        public static ExcelWorkbook excelWorkbook = excelPackage.Workbook;
        public static ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets.Add("BatteriestTestDocument");

        public static int row = 2;
        public static int column = 1;

        public static void ExcelRestart()
        {
            row = 2;
            column = 1;
            fileCounter++;

            ExcelBrowse = Path.Combine(SelectedDirectory, SelectedFileNameWithoutExtension + Convert.ToString(fileCounter) + SelectedExtension);
            SelectedFilePath = ExcelBrowse;

            fileInfo = new FileInfo(ExcelBrowse);
            excelPackage = new ExcelPackage();
            excelWorkbook = excelPackage.Workbook;
            excelWorksheet = excelPackage.Workbook.Worksheets.Add("BatteriestTestDocument");
        }

        public static void ExcelStartSave(string Test)
        {
            StartSavingExcel = true;
            excelWorksheet.TabColor = Color.Blue;

            switch (Test)
            {
                case "AT":
                    excelWorksheet.Cells[1, 1].Value = "Status";
                    excelWorksheet.Cells[1, 2].Value = "Cycle";
                    excelWorksheet.Cells[1, 3].Value = "Voltage";
                    excelWorksheet.Cells[1, 4].Value = "Current";
                    excelWorksheet.Cells[1, 5].Value = "Temperature";

                    excelWorksheet.Column(1).AutoFit();
                    excelWorksheet.Column(2).AutoFit();
                    excelWorksheet.Column(3).AutoFit();
                    excelWorksheet.Column(4).AutoFit();
                    excelWorksheet.Column(5).AutoFit();
                    break;
                case "RC":
                    excelWorksheet.Cells[1, 1].Value = "Voltage";
                    excelWorksheet.Cells[1, 2].Value = "Current";

                    excelWorksheet.Column(1).AutoFit();
                    excelWorksheet.Column(2).AutoFit();
                    break;
            }

            excelWorksheet.Row(1).Style.Font.Bold = true;
            excelWorksheet.Row(1).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            excelWorksheet.Row(1).Style.Fill.BackgroundColor.SetColor(Color.Turquoise);

            excelWorksheet.Workbook.Properties.Title = "Batteriest" + fileCounter;
            excelWorksheet.Workbook.Properties.Company = "Batteriest Inc.";
        }
        public static void ExcelData(string Test)
        {
            if (StartSavingExcel == true)
            {
                switch (Test)
                {
                    case "AT":
                        excelWorksheet.Cells[row, column].Value = SerialPortCom.floatstatus; column++;
                        excelWorksheet.Cells[row, column].Value = Options.CycleCounter; column++;
                        excelWorksheet.Cells[row, column].Value = SerialPortCom.floatvolt; column++;
                        excelWorksheet.Cells[row, column].Value = SerialPortCom.floatcurrent; column++;
                        excelWorksheet.Cells[row, column].Value = SerialPortCom.temp; row++; column = 1;
                        break;
                    case "RC":
                        excelWorksheet.Cells[row, column].Value = float.Parse(SerialPortCom.serialDataArray[1], Options.cultureInfo); column++;
                        excelWorksheet.Cells[row, column].Value = float.Parse(SerialPortCom.serialDataArray[2], Options.cultureInfo); row++; column = 1;
                        break;
                }
            }
        }
        public static void ExcelEndSave()
        {
            StartSavingExcel = false;
            excelPackage.SaveAs(Excel.ExcelBrowse);
            excelPackage.Dispose();
        }
    }
}
