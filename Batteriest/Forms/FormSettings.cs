using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace Batteriest
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            textMaxVoltage.Text = Options.MaxVoltage.ToString();
            textMinVoltage.Text = Options.MinVoltage.ToString();
            textBatCapacity.Text = Options.BatteryCapacity.ToString();
            textCycle.Text = Options.Cycle.ToString();
            textMaxTemp.Text = Options.MaxTemp.ToString();
            textFilePath.Text = Excel.ExcelBrowse;
        }
        
        private void RoundedExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "BatteriesTest";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Options.SelectedFilePath = saveFileDialog.FileName;
                Options.SelectedDirectory = Path.GetDirectoryName(saveFileDialog.FileName);
                Options.SelectedFileNameWithoutExtension = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                Options.SelectedExtension = Path.GetExtension(saveFileDialog.FileName);
            }

            textFilePath.Text = Options.SelectedFilePath;
        }

        private void TextGeneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void RoundedSaveData_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textMaxVoltage.Text, out Options.MaxVoltage)) { }
            else { MessageBox.Show("Lütfen geçerli bir sayı girin!"); }
            if (float.TryParse(textMinVoltage.Text, out Options.MinVoltage)) { }
            else { MessageBox.Show("Lütfen geçerli bir sayı girin!"); }
            if (float.TryParse(textCycle.Text, out Options.Cycle)) { }
            else { MessageBox.Show("Lütfen geçerli bir sayı girin!"); }
            if (float.TryParse(textMaxTemp.Text, out Options.MaxTemp)) { }
            else { MessageBox.Show("Lütfen geçerli bir sayı girin!"); }
            if (float.TryParse(textBatCapacity.Text, out Options.BatteryCapacity)) { }
            else { MessageBox.Show("Lütfen geçerli bir sayı girin!"); }
            
            labelC5.Show();
            labelC5.Text = "Saved!";
            
            var stopwatch = Stopwatch.StartNew();
            while (stopwatch.Elapsed.TotalSeconds < 1) {
                Application.DoEvents();
            }

            labelC5.Hide();
        }
        private void RoundedResetData_Click(object sender, EventArgs e)
        {
            Options.MaxVoltage = 4.2F;
            textMaxVoltage.Text = Options.MaxVoltage.ToString();

            Options.MinVoltage = 2.75F;
            textMinVoltage.Text = Options.MinVoltage.ToString();
            
            Options.Cycle = 300;
            textCycle.Text = Options.Cycle.ToString();
            
            Options.BatteryCapacity = 2;
            textBatCapacity.Text = Options.BatteryCapacity.ToString();
            
            Options.MaxTemp = 45;
            textMaxTemp.Text = Options.MaxTemp.ToString();

            Options.SelectedFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), string.Format("BatteriestTest{0}.xlsx", Options.fileCounter));
            Options.SelectedDirectory = Path.GetDirectoryName(Options.SelectedFilePath);
            Options.SelectedFileNameWithoutExtension = Path.GetFileNameWithoutExtension(Options.SelectedFilePath);
            Options.SelectedExtension = Path.GetExtension(Options.SelectedFilePath);
            
            textFilePath.Text = Options.SelectedFilePath;

            labelC5.Show();
            labelC5.Text = "Restored!";

            var stopwatch2 = Stopwatch.StartNew();
            while (stopwatch2.Elapsed.TotalSeconds < 1) {
                Application.DoEvents();
            }

            labelC5.Hide();
        }
    }
}