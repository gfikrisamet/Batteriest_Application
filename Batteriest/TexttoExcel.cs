using OfficeOpenXml;
using System;

using System.IO;
using System.Windows.Forms;

namespace Batteriest
{
    public static class TexttoExcel
    {
        public static string txtFilePath = TextFile.SelectedFilePath;
        public static string excelFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), string.Format(Excel.SelectedFileNameWithoutExtension + "PD" + TextFile.fileCounter + Excel.SelectedExtension));

        public static void ConvertTxtToExcel(string testName)
        {
            excelFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), string.Format(Excel.SelectedFileNameWithoutExtension + testName + TextFile.fileCounter + Excel.SelectedExtension));
            try
            {
                FileInfo excelFile = new FileInfo(excelFilePath);
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("BatteriestRCEsmtimate" + TextFile.fileCounter);

                    using (StreamReader sr = new StreamReader(txtFilePath))
                    {
                        string line;
                        int row = 1;

                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] values = line.Split(',');
                            for (int col = 0; col < values.Length; col++)
                            {
                                worksheet.Cells[row, col + 1].Value = values[col];
                            }
                            row++;
                        }
                    }


                    excelPackage.SaveAs(excelFile);
                    excelPackage.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                TextFile.fileCounter++;
            }
        }
    }
}