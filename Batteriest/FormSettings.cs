using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Batteriest
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            UpdateTextBox();
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
                Excel.SelectedFilePath = saveFileDialog.FileName;
                Excel.SelectedDirectory = Path.GetDirectoryName(saveFileDialog.FileName);
                Excel.SelectedFileNameWithoutExtension = Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                Excel.SelectedExtension = Path.GetExtension(saveFileDialog.FileName);
            }

            textFilePath.Text = Excel.SelectedFilePath;
        }
        private void TextGeneral_KeyPress_Float(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void TextGeneral_KeyPress_Integer(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void RoundedSaveData_Click(object sender, EventArgs e)
        {
            Options.SavedSettings = true;
            if (float.TryParse(textRCVoltage.Text, NumberStyles.Float, Options.cultureInfo, out Options.RCVoltage)) { }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                Options.SavedSettings = false;
            }

            if (float.TryParse(textRCRestTime.Text, NumberStyles.Float, Options.cultureInfo, out Options.RCRestTime)) { }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                Options.SavedSettings = false;
            }

            if (float.TryParse(textRCHighS.Text, NumberStyles.Float, Options.cultureInfo, out Options.RCHighSSample)) { }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                Options.SavedSettings = false;
            }

            if (float.TryParse(textRCLowS.Text, NumberStyles.Float, Options.cultureInfo, out Options.RCLowSSample)) { }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                Options.SavedSettings = false;
            }

            if (float.TryParse(textATMaxVoltage.Text, NumberStyles.Float, Options.cultureInfo, out Options.ATMaxVoltage)) { }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                Options.SavedSettings = false;
            }

            if (float.TryParse(textATMinVoltage.Text, NumberStyles.Float, Options.cultureInfo, out Options.ATMinVoltage)) { }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                Options.SavedSettings = false;
            }

            if (float.TryParse(textATCycle.Text, NumberStyles.Float, Options.cultureInfo, out Options.ATCycle)) { }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                Options.SavedSettings = false;
            }

            if (float.TryParse(textSMaxVoltage.Text, NumberStyles.Float, Options.cultureInfo, out Options.SMaxVoltage)) { }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                Options.SavedSettings = false;
            }

            if (float.TryParse(textSMinVoltage.Text, NumberStyles.Float, Options.cultureInfo, out Options.SMinVoltage)) { }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                Options.SavedSettings = false;
            }

            if (float.TryParse(textSMaxTemp.Text, NumberStyles.Float, Options.cultureInfo, out Options.SMaxTemp)) { }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                Options.SavedSettings = false;
            }

            if (int.TryParse(textHASample.Text, out Options.HASampleTime)) { }
            else
            {
                MessageBox.Show("Please enter a valid number!");
                Options.SavedSettings = false;
            }

            if (Options.SavedSettings == false)
            {
                labelC5.Show();
                labelC5.Text = "ERROR!";
                labelC5.ForeColor = Color.Red;
            }
            else
            {
                labelC5.Show();
                labelC5.ForeColor = Color.FromArgb(0, 126, 249);
                labelC5.Text = "Saved!";

                var settings1watch = Stopwatch.StartNew();
                while (settings1watch.Elapsed.TotalSeconds < 1)
                {
                    Application.DoEvents();
                }

                labelC5.Hide();
            }
        }
        private void RoundedResetData_Click(object sender, EventArgs e)
        {
            Options.RCVoltage = 4.1F;
            Options.RCRestTime = 60;
            Options.RCHighSSample = 15;
            Options.RCLowSSample = 85;
            Options.ATMaxVoltage = 4.2F;
            Options.ATMinVoltage = 2.7F;
            Options.ATCycle = 200;
            Options.SMaxVoltage = 4.25F;
            Options.SMinVoltage = 2.65F;
            Options.SMaxTemp = 45;
            Options.HASampleTime = 20;

            Excel.SelectedFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), string.Format("BatteriestTest" + Excel.fileCounter + ".xlsx"));
            Excel.SelectedDirectory = Path.GetDirectoryName(Excel.SelectedFilePath);
            Excel.SelectedFileNameWithoutExtension = Path.GetFileNameWithoutExtension(Excel.SelectedFilePath);
            Excel.SelectedExtension = Path.GetExtension(Excel.SelectedFilePath);

            UpdateTextBox();

            labelC5.Show();
            labelC5.Text = "Restored!";

            var settings2watch = Stopwatch.StartNew();
            while (settings2watch.Elapsed.TotalSeconds < 1)
            {
                Application.DoEvents();
            }

            labelC5.Hide();
        }
        private void UpdateTextBox()
        {
            textRCVoltage.Text = Options.RCVoltage.ToString(Options.cultureInfo);
            textRCRestTime.Text = Options.RCRestTime.ToString(Options.cultureInfo);
            textRCHighS.Text = Options.RCHighSSample.ToString(Options.cultureInfo);
            textRCLowS.Text = Options.RCLowSSample.ToString(Options.cultureInfo);
            textATMaxVoltage.Text = Options.ATMaxVoltage.ToString(Options.cultureInfo);
            textATMinVoltage.Text = Options.ATMinVoltage.ToString(Options.cultureInfo);
            textATCycle.Text = Options.ATCycle.ToString(Options.cultureInfo);
            textSMaxVoltage.Text = Options.SMaxVoltage.ToString(Options.cultureInfo);
            textSMinVoltage.Text = Options.SMinVoltage.ToString(Options.cultureInfo);
            textSMaxTemp.Text = Options.SMaxTemp.ToString(Options.cultureInfo);
            textFilePath.Text = Excel.SelectedFilePath;
            textHASample.Text = Options.HASampleTime.ToString(Options.cultureInfo);
        }
    }
}