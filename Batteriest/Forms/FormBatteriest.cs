using OfficeOpenXml;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace Batteriest
{
    public partial class Batteriest : Form
    {
        bool Mov;
        int MovX;
        int MovY;
        public Batteriest()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            System.Drawing.Drawing2D.GraphicsPath graphPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphPath.AddArc(0, 0, 15, 15, 180, 90);
            graphPath.AddLine(20, 0, this.Width - 15, 0);
            graphPath.AddArc(this.Width - 15, 0, 15, 15, 270, 90);
            graphPath.AddLine(this.Width, 15, this.Width, this.Height - 15);
            graphPath.AddArc(this.Width - 15, this.Height - 15, 15, 15, 0, 90);
            graphPath.AddLine(this.Width - 15, this.Height, 15, this.Height);
            graphPath.AddArc(0, this.Height - 15, 15, 15, 90, 90);
            graphPath.AddLine(0, this.Height - 15, 0, 15);
            Region = new Region(graphPath);

            LoadForm(Options.formStatus);
            PanelNavigation(buttonStatus);
        }

        //Formlar Arası Geçiş Butonları//
        private void ButtonStatus_Click(object sender, EventArgs e)
        {
            Options.colorStatus = true;
            Options.colorHarmonic = false;
            Options.colorSettings = false;
            Options.colorAboutUs = false;

            LoadForm(Options.formStatus);
            PanelNavigation(buttonStatus);
            labelForm.Text = "Status";
        }
        private void ButtonHarmonic_Click(object sender, EventArgs e)
        {
            Options.colorStatus = false;
            Options.colorHarmonic = true;
            Options.colorSettings = false;
            Options.colorAboutUs = false;
            LoadForm(new FormHarmonicAnalysis());
            PanelNavigation(buttonHarmonic);
            labelForm.Text = "Harmonic Analysis";
        }
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            Options.colorStatus = false;
            Options.colorHarmonic = false;
            Options.colorSettings = true;
            Options.colorAboutUs = false;
            LoadForm(new FormSettings());
            PanelNavigation(buttonSettings);
            labelForm.Text = "Settings";
        }
        private void ButtonAboutUs_Click(object sender, EventArgs e)
        {
            Options.colorStatus = false;
            Options.colorHarmonic = false;
            Options.colorSettings = false;
            Options.colorAboutUs = true;
            LoadForm(new FormAboutUs());
            PanelNavigation(buttonAboutUs);
            labelForm.Text = "About Us";
        }

        //Uygulama Penceresini Taşıma//
        private void PanelApp_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
        private void PanelApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }
        private void PanelApp_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        //Uygulama Butonları//
        private void RoundedHideApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void RoundedCloseApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Serial Port Butonları//
        private void RoundedConnectSerial_Click(object sender, EventArgs e)
        {
            try
            {
                Options.PortName = comboSerialBox.Text;

                SerialPortCom.ConnectToSerialPort();

                if (Options.PortState == true)
                {
                    comboSerialBox.Enabled = false;
                    roundedConnectSerial.Enabled = false;
                    roundedDisconnectSerial.Enabled = true;
                    comboSerialBox.BackColor = Color.Green;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ("hata:"));
            }
        }
        private void RoundedDisconnectSerial_Click(object sender, EventArgs e)
        {
            try
            {
                Options.Status = 0;
                SerialPortCom.SerialPort_WriteData();

                SerialPortCom.ConnectToSerialPort();

                if (Options.PortStateOff == true)
                {
                    comboSerialBox.ResetText();
                    comboSerialBox.Enabled = true;
                    roundedConnectSerial.Enabled = true;
                    roundedDisconnectSerial.Enabled = false;

                    comboSerialBox.BackColor = Color.Red;
                }

                if (Excel.StartSavingExcel == true)
                {
                    Excel.ExcelEndSave();

                    Excel.ExcelRestart();
                    Excel.StartSavingExcel = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ("hata:"));
            }
        }

        //Serial Port ComboBox//
        public void ComboSerialBox_DropDown(object sender, EventArgs e)
        {
            comboSerialBox.Items.Clear();

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                if (port == "") { }
                else
                {
                    comboSerialBox.Items.Add(port);
                }
            }
        }

        //Form Yükleme//
        public void LoadForm(object loadForm)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }

            Form mainPanel = loadForm as Form;
            mainPanel.TopLevel = false;
            mainPanel.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(mainPanel);

            mainPanel.Show();
        }

        //Form Veri Güncelleme//
        public static void UpdateVoltageLabel(string voltage)
        {
            if (Options.formStatus.labelVoltage.InvokeRequired && Options.PortState == true)
            {
                Options.formStatus.labelVoltage.Invoke((MethodInvoker)delegate
                    {
                        Options.formStatus.labelVoltage.Text = voltage;
                    });
            }
            else
            {
                Options.formStatus.labelVoltage.Invoke((MethodInvoker)delegate
                {
                    Options.formStatus.labelVoltage.Text = voltage;
                });
            }
        }
        public static void UpdateCurrentLabel(string current)
        {
            if (Options.formStatus.labelCurrent.InvokeRequired && Options.PortState == true)
            {
                Options.formStatus.labelCurrent.Invoke((MethodInvoker)delegate
                {
                    Options.formStatus.labelCurrent.Text = current;
                });
            }
            else
            {
                Options.formStatus.labelCurrent.Invoke((MethodInvoker)delegate
                {
                    Options.formStatus.labelCurrent.Text = current;
                });
            }
        }
        public static void UpdateTempLabel(string temp)
        {
            if (Options.formStatus.labelTemp.InvokeRequired && Options.PortState == true)
            {
                Options.formStatus.labelTemp.Invoke((MethodInvoker)delegate
                {
                    Options.formStatus.labelTemp.Text = temp;
                });
            }
            else
            {
                Options.formStatus.labelTemp.Invoke((MethodInvoker)delegate
                {
                    Options.formStatus.labelTemp.Text = temp;
                });
            }
        }
        public static void UpdateCycleLabel(string cycle)
        {
            if (Options.formStatus.labelCycle.InvokeRequired && Options.PortState == true && Cycle.CycleStart == true)
            {
                Options.formStatus.labelCycle.Invoke((MethodInvoker)delegate
                {
                    Options.formStatus.labelCycle.Text = cycle;
                });
            }
            else
            {
                Options.formStatus.labelCycle.Invoke((MethodInvoker)delegate
                {
                    Options.formStatus.labelCycle.Text = cycle;
                });
            }
        }
        public static void UpdateCycleButtons()
        {
            Options.formStatus.labelCycle.Invoke((MethodInvoker)delegate
            {
                Options.formStatus.roundedCharge.Enabled = true;
                Options.formStatus.roundedDischarge.Enabled = true;
                Options.formStatus.roundedIdle.Enabled = false;
                Options.formStatus.roundedCycleStart.Enabled = true;
                Options.formStatus.roundedCycleStop.Enabled = false;
            });
        }

        //Form Buton Ayarları//
        public void PanelNavigation(object sender)
        {
            Button btn = (Button)sender;
            panelNavigation.Height = btn.Height;
            panelNavigation.Top = btn.Top;
            panelNavigation.Left = btn.Left;

            btn.FlatAppearance.BorderColor = Color.FromArgb(46, 51, 73);

            if (Options.colorStatus == true)
            {
                btn.BackColor = Color.FromArgb(46, 51, 73);
                buttonHarmonic.BackColor = Color.FromArgb(24, 30, 54);
                buttonSettings.BackColor = Color.FromArgb(24, 30, 54);
                buttonAboutUs.BackColor = Color.FromArgb(24, 30, 54);
            }
            else if (Options.colorHarmonic == true)
            {
                btn.BackColor = Color.FromArgb(46, 51, 73);
                buttonStatus.BackColor = Color.FromArgb(24, 30, 54);
                buttonSettings.BackColor = Color.FromArgb(24, 30, 54);
                buttonAboutUs.BackColor = Color.FromArgb(24, 30, 54);
            }
            else if (Options.colorSettings == true)
            {
                btn.BackColor = Color.FromArgb(46, 51, 73);
                buttonHarmonic.BackColor = Color.FromArgb(24, 30, 54);
                buttonStatus.BackColor = Color.FromArgb(24, 30, 54);
                buttonAboutUs.BackColor = Color.FromArgb(24, 30, 54);
            }
            else if (Options.colorAboutUs == true)
            {
                btn.BackColor = Color.FromArgb(46, 51, 73);
                buttonHarmonic.BackColor = Color.FromArgb(24, 30, 54);
                buttonSettings.BackColor = Color.FromArgb(24, 30, 54);
                buttonStatus.BackColor = Color.FromArgb(24, 30, 54);
            }
            else { }
        }
    }

    public class Options
    {
        public static string PortName = "COM1";
        public static bool PortState = false;
        public static bool PortStateOff = false;

        public static int Status = 0;
        public static int CycleCounter = 1;

        public static float MaxVoltage = 4.2F;
        public static float MinVoltage = 2.75F;
        public static float BatteryCapacity = 2;
        public static float Cycle = 100;
        public static float MaxTemp = 45;

        public static bool colorStatus = true;
        public static bool colorHarmonic = false;
        public static bool colorSettings = false;
        public static bool colorAboutUs = false;

        public static FormStatus formStatus = new FormStatus();

        public static int fileCounter = 0;
        public static string SelectedFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), string.Format("Batteriest.xlsx"));
        public static string SelectedDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string SelectedFileNameWithoutExtension = "Batteriest";
        public static string SelectedExtension = ".xlsx";
    }
    
    public class SerialPortCom
    {
        public static SerialPort mySerialPort;

        public static string voltage;
        public static string current;
        public static string temp;
        public static string cycle;
        public static string[] serialData;

        public static float voltageExit;
        public static float tempExit;

        public static CultureInfo cultureInfo = new CultureInfo("en-US");

        public static void ConnectToSerialPort()
        {
            if (Options.PortState == false)
            {
                try
                {
                    mySerialPort = new SerialPort(Options.PortName)
                    {
                        BaudRate = 115200,
                        Parity = Parity.None,
                        StopBits = StopBits.One,
                        DataBits = 8,
                        Handshake = Handshake.None,
                        RtsEnable = true
                    };
                    mySerialPort.Open();
                    mySerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                    Options.PortState = true;
                    Options.PortStateOff = false;
                }
                catch
                {
                    MessageBox.Show("Error: Please Select a Serial Port");
                }
            }

           else if (Options.PortStateOff == false)
            {

                mySerialPort.DataReceived -= new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                Options.PortState = false;
                Options.PortStateOff = true;
                Batteriest.UpdateVoltageLabel("-");
                Batteriest.UpdateCurrentLabel("-");
                Batteriest.UpdateTempLabel("-");
                Batteriest.UpdateCycleLabel("-");
                System.Threading.Thread.Sleep(2000);
                mySerialPort.Close();
            }
        }
        public static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialData = mySerialPort.ReadLine().Split('/');
            voltage = serialData[1];
            current = serialData[2];
            temp = serialData[3];

            cycle = Options.CycleCounter.ToString();
            voltageExit = float.Parse(voltage, cultureInfo);
            tempExit = float.Parse(temp, cultureInfo);

            if (Excel.StartSavingExcel == true)
            {
                Excel.ExcelData();
            }
                
            if(voltageExit >= Options.MaxVoltage && Cycle.CycleStart == false || voltageExit <= Options.MinVoltage && Cycle.CycleStart == false || tempExit >= Options.MaxTemp && Cycle.CycleStart==false)
            {
                Options.Status = 0;
                SerialPort_WriteData();
                MessageBox.Show("Test has been stopped for security!");
                if (Excel.StartSavingExcel == true)
                {
                    Excel.StartSavingExcel = false;
                    Excel.ExcelEndSave();
                }
            }

            if(Cycle.CycleStart == true)
            {
                cycle = Options.CycleCounter.ToString();
                Batteriest.UpdateCycleLabel(cycle);

                if (voltageExit >= Options.MaxVoltage)
                {
                    Options.Status = 2; 
                    SerialPort_WriteData();
                    
                }

                if(voltageExit <= Options.MinVoltage)
                {
                    Options.CycleCounter++;
                    if (Options.CycleCounter == Options.Cycle+1)
                    {
                        Options.Status = 0;
                        SerialPort_WriteData();

                        Cycle.CycleStart = false;

                        Excel.StartSavingExcel = false;
                        Excel.ExcelEndSave();
                        Batteriest.UpdateCycleButtons();
                        MessageBox.Show($"{Options.CycleCounter-1} cycle has been successfully completed!");
                    }
                    else
                    {
                        Options.Status = 1;
                        SerialPort_WriteData();
                    }
                }
            }
            Batteriest.UpdateVoltageLabel(voltage);
            Batteriest.UpdateCurrentLabel(current);
            Batteriest.UpdateTempLabel(temp);
        }
        public static void SerialPort_WriteData()
        {
            if (Options.Status == 1 && Options.PortState == true)
            {
                mySerialPort.Write("charge");
            }
            if (Options.Status == 2 && Options.PortState == true)
            {
                mySerialPort.Write("discharge");
            }
            if (Options.Status == 0 && Options.PortState == true)
            {
                mySerialPort.Write("idle");
            }
        }
    }
    
    public class Cycle
    {
        public static bool CycleStart = false;
        public static void StartCycle()
        {
            if (Options.PortState == true)
            {
                CycleStart = true;
                Options.CycleCounter = 1;
                Options.Status = 1;
                SerialPortCom.SerialPort_WriteData();

                if (Excel.StartSavingExcel == false)
                {
                    Excel.ExcelStartSave();
                    Excel.StartSavingExcel = true;
                }
            }
        }
        public static void StopCycle()
        {
            if (Options.PortState == true)
            {
                CycleStart = false;
                Options.Status = 0;
                SerialPortCom.SerialPort_WriteData();

                if (Excel.StartSavingExcel == true)
                {
                    Excel.ExcelEndSave();
                    Excel.ExcelRestart();
                    Excel.StartSavingExcel = false;
                }
            }
        }
    }

    public class Excel
    {
        public static bool StartSavingExcel = false;
        public static bool Reset = false;

        public static string ExcelBrowse = Options.SelectedFilePath;

        public static FileInfo fileInfo = new FileInfo(ExcelBrowse);
        public static ExcelPackage excelPackage = new ExcelPackage();
        public static ExcelWorkbook excelWorkbook = excelPackage.Workbook;
        public static ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets.Add("BatteriestTestDocument");

        public static int row = 2;
        public static int column = 1;

        public static void ExcelRestart()
        {
            row = 2;
            column =1;
            Options.fileCounter++;

            ExcelBrowse = Path.Combine(Options.SelectedDirectory, Options.SelectedFileNameWithoutExtension + Convert.ToString(Options.fileCounter) + Options.SelectedExtension);
            Options.SelectedFilePath = ExcelBrowse;

            fileInfo = new FileInfo(ExcelBrowse);
            excelPackage = new ExcelPackage();
            excelWorkbook = excelPackage.Workbook;
            excelWorksheet = excelPackage.Workbook.Worksheets.Add("BatteriestTestDocument");
        }
        public static void ExcelStartSave()
        {
            excelWorksheet.TabColor = Color.Blue;

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

            excelWorksheet.Row(1).Style.Font.Bold = true;
            excelWorksheet.Row(1).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            excelWorksheet.Row(1).Style.Fill.BackgroundColor.SetColor(Color.Turquoise);

            excelWorksheet.Workbook.Properties.Title = "Batteriest Test Dococument";
            excelWorksheet.Workbook.Properties.Author = "fstorm & Lowich";
            excelWorksheet.Workbook.Properties.Company = "Batteriest Test Company";
        }
        public static void ExcelData()
        {
            if (StartSavingExcel == true)
            {
                excelWorksheet.Cells[row, column].Value = float.Parse(SerialPortCom.serialData[0], SerialPortCom.cultureInfo); column++;
                excelWorksheet.Cells[row, column].Value = Options.CycleCounter; column++;
                excelWorksheet.Cells[row, column].Value = float.Parse(SerialPortCom.serialData[1], SerialPortCom.cultureInfo); column++;
                excelWorksheet.Cells[row, column].Value = float.Parse(SerialPortCom.serialData[2], SerialPortCom.cultureInfo); column++;
                excelWorksheet.Cells[row, column].Value = float.Parse(SerialPortCom.serialData[3], SerialPortCom.cultureInfo); row++; column = 1;
            }
        }
        public static void ExcelEndSave()
        {
            excelPackage.SaveAs(Excel.ExcelBrowse);
            excelPackage.Dispose();
        }
    }
}



