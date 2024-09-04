using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Batteriest
{
    public partial class Batteriest : Form
    {

        public Batteriest()
        {
            InitializeComponent();
            LoadApp();

            roundedDisconnectSerial.Enabled = false;

            LoadForm(Options.formAbout);
            PanelNavigation(buttonAboutUs);
        }

        //FORMLAR ARASI GEÇİŞ BUTONLARI//
        private void ButtonRCEstimate_Click(object sender, EventArgs e)
        {
            LoadForm(Options.formRC);
            PanelNavigation(buttonRCEstimate);
            labelForm.Text = "Pulse-Discharge Test";
        }
        private void ButtonAgingTest_Click(object sender, EventArgs e)
        {
            LoadForm(Options.formAging);
            PanelNavigation(buttonAgingTest);
            labelForm.Text = "Aging Test";
            Options.SP_State = 3;
        }
        private void ButtonHarmonic_Click(object sender, EventArgs e)
        {
            LoadForm(Options.formHarmonic);
            PanelNavigation(buttonHarmonic);
            labelForm.Text = "Harmonic Analysis";
        }
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            LoadForm(new FormSettings());
            PanelNavigation(buttonSettings);
            labelForm.Text = "Settings";
        }
        private void ButtonAboutUs_Click(object sender, EventArgs e)
        {
            LoadForm(Options.formAbout);
            PanelNavigation(buttonAboutUs);
            labelForm.Text = "About Us";
        }
        //END CODE//

        //FORM YUKLEME VE FORM BUTON AYARLARI//
        private void LoadApp()
        {
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
        }
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
        public void PanelNavigation(object sender)
        {
            Button btn = (Button)sender;
            panelNavigation.Height = btn.Height;
            panelNavigation.Top = btn.Top;
            panelNavigation.Left = btn.Left;

            btn.FlatAppearance.BorderColor = Color.FromArgb(46, 51, 73);

            if (btn == buttonRCEstimate)
            {
                btn.BackColor = Color.FromArgb(46, 51, 73);
                buttonAgingTest.BackColor = Color.FromArgb(24, 30, 54);
                buttonHarmonic.BackColor = Color.FromArgb(24, 30, 54);
                buttonSettings.BackColor = Color.FromArgb(24, 30, 54);
                buttonAboutUs.BackColor = Color.FromArgb(24, 30, 54);
            }
            else if (btn == buttonAgingTest)
            {
                btn.BackColor = Color.FromArgb(46, 51, 73);
                buttonRCEstimate.BackColor = Color.FromArgb(24, 30, 54);
                buttonHarmonic.BackColor = Color.FromArgb(24, 30, 54);
                buttonSettings.BackColor = Color.FromArgb(24, 30, 54);
                buttonAboutUs.BackColor = Color.FromArgb(24, 30, 54);
            }
            else if (btn == buttonHarmonic)
            {
                btn.BackColor = Color.FromArgb(46, 51, 73);
                buttonRCEstimate.BackColor = Color.FromArgb(24, 30, 54);
                buttonAgingTest.BackColor = Color.FromArgb(24, 30, 54);
                buttonSettings.BackColor = Color.FromArgb(24, 30, 54);
                buttonAboutUs.BackColor = Color.FromArgb(24, 30, 54);
            }
            else if (btn == buttonSettings)
            {
                btn.BackColor = Color.FromArgb(46, 51, 73);
                buttonRCEstimate.BackColor = Color.FromArgb(24, 30, 54);
                buttonAgingTest.BackColor = Color.FromArgb(24, 30, 54);
                buttonHarmonic.BackColor = Color.FromArgb(24, 30, 54);
                buttonAboutUs.BackColor = Color.FromArgb(24, 30, 54);
            }
            else if (btn == buttonAboutUs)
            {
                btn.BackColor = Color.FromArgb(46, 51, 73);
                buttonRCEstimate.BackColor = Color.FromArgb(24, 30, 54);
                buttonAgingTest.BackColor = Color.FromArgb(24, 30, 54);
                buttonHarmonic.BackColor = Color.FromArgb(24, 30, 54);
                buttonSettings.BackColor = Color.FromArgb(24, 30, 54);
            }
            else
            {
                MessageBox.Show("Something went wrong. Contact us.");
            }
        }
        //END CODE//

        //UYGULAMA PENCERESİNİ TAŞIMA//
        private void PanelApp_MouseDown(object sender, MouseEventArgs e)
        {
            Options.Mov = true;
            Options.MovX = e.X;
            Options.MovY = e.Y;
        }
        private void PanelApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (Options.Mov)
            {
                this.SetDesktopLocation(MousePosition.X - Options.MovX, MousePosition.Y - Options.MovY);
            }
        }
        private void PanelApp_MouseUp(object sender, MouseEventArgs e)
        {
            Options.Mov = false;
        }
        //END CODE//

        //UYGULAMA BUTONLARI//
        private void RoundedHideApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void RoundedCloseApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //END CODE//

        //SERİAL PORT BAĞLANTI VE SERİAL PORT SEÇME BUTONLARI//
        private void RoundedConnectSerial_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPortCom.PortName = comboSerialBox.Text;

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
                if (Options.SP_State == 1 || Options.SP_State == 2 || Options.SP_State == 4)
                {
                    SerialPortCom.DisconnectToSerialPort('R');
                }
                else if (Options.SP_State == 3)
                {
                    SerialPortCom.DisconnectToSerialPort('A');
                }

                if (Options.PortState == false)
                {
                    comboSerialBox.ResetText();
                    comboSerialBox.Enabled = true;
                    roundedConnectSerial.Enabled = true;
                    roundedDisconnectSerial.Enabled = false;

                    comboSerialBox.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ("hata:"));
            }
        }
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
    }
}



