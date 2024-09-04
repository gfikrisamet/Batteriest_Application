using System;
using System.Drawing;
using System.Windows.Forms;

namespace Batteriest
{
    public partial class FormPulseDischarge : Form
    {
        public FormPulseDischarge()
        {
            InitializeComponent();
            roundedPDStopButton.Enabled = false;
        }

        private void RoundedPDStartButton_Click(object sender, EventArgs e)
        {
            if (Options.PortState == true)
            {
                Options.SP_State = 1;
                roundedPDStartButton.Enabled = false;
                SerialPortCom.SerialPort_WriteData("charge");
                roundedPDStopButton.Enabled = true;

            }
            else
            {
                MessageBox.Show("It does not connect the serial port!", "Error");
            }
        }

        private void RoundedPDStopButton_Click(object sender, EventArgs e)
        {

            if (pictureStage2.BackColor == Color.Yellow)
            {
                Options.formRC.labelRC_Second.ForeColor = Color.White;
                CountdownTimer.countdownSeconds2 = 0;
                CountdownTimer.timer2.Stop();
                CountdownTimer.timer2.Dispose();
            }
            if (pictureStage2.BackColor == Color.Green)
            {
                Excel.ExcelEndSave();
            }
            if (pictureStage3.BackColor == Color.Green)
            {
                TextFile.StopLogging();
            }
            Options.SP_State = 61;
            roundedPDStartButton.Enabled = true;
            UpdateData.UpdateRCDone();


        }

        private void PictureStage1_BackColorChanged(object sender, EventArgs e)
        {
            if (pictureStage1.BackColor == Color.Yellow)
            {
                SerialPortCom.SerialPort_WriteData("charge");
            }
            else if (pictureStage1.BackColor == Color.Green)
            {
                SerialPortCom.SerialPort_WriteData("idle");
                CountdownTimer.StartCountdownS2(Options.RCRestTime);
            }
        }
        private void PictureStage2_BackColorChanged(object sender, EventArgs e)
        {
            if (pictureStage2.BackColor == Color.Green)
            {
                UpdateData.UpdateRCValueLabels("-", "-");
                Excel.ExcelStartSave("RC");
                Options.SP_State = 2;
                CountdownTimer.StartCountdownS3(3);
            }
        }

        public void PictureStage3_BackColorChanged(object sender, EventArgs e)
        {
            if (pictureStage3.BackColor == Color.Green)
            {
                TextFile.StartLogging("PDT");
            }
        }
        private void PictureStage4_BackColorChanged(object sender, EventArgs e)
        {
            if (pictureStage4.BackColor == Color.Green)
            {
                UpdateData.UpdateRCDone();
                roundedPDStartButton.Enabled = true;
                roundedPDStopButton.Enabled = false;
            }
        }
    }
}
