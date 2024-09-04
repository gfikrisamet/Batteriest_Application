using System;
using System.Windows.Forms;

namespace Batteriest
{
    public partial class FormAgingTest : Form
    {
        public FormAgingTest()
        {
            InitializeComponent();
        }

        //Manuel Röle Kontrolü//
        private void RoundedCharge_Click(object sender, EventArgs e)
        {
            if (Options.PortState == true)
            {
                SerialPortCom.SerialPort_WriteData("charge");
                Excel.ExcelStartSave("AT");
                roundedCharge.Enabled = false;
                roundedDischarge.Enabled = true;
                roundedCycleStart.Enabled = false;
                roundedCycleStop.Enabled = false;
            }
        }
        private void RoundedDischarge_Click(object sender, EventArgs e)
        {
            if (Options.PortState == true)
            {
                SerialPortCom.SerialPort_WriteData("discharge_m1");
                Excel.ExcelStartSave("AT");
                roundedCharge.Enabled = true;
                roundedDischarge.Enabled = false;
                roundedCycleStart.Enabled = false;
                roundedCycleStop.Enabled = false;
            }
        }
        private void RoundedIdle_Click(object sender, EventArgs e)
        {
            if (Options.PortState == true)
            {
                SerialPortCom.SerialPort_WriteData("idle");
                Excel.ExcelEndSave();
                Excel.ExcelRestart();
                roundedCharge.Enabled = true;
                roundedDischarge.Enabled = true;
                roundedCycleStart.Enabled = true;
                roundedCycleStop.Enabled = true;
            }
        }

        //Cycle Status Butonları Yapılandırması//
        private void RoundedCycleStart_Click(object sender, EventArgs e)
        {
            if (Options.PortState == true)
            {
                CycleSet.StartCycle();
                Excel.ExcelStartSave("AT");
                roundedCharge.Enabled = false;
                roundedDischarge.Enabled = false;
                roundedCycleStart.Enabled = false;
                roundedCycleStop.Enabled = true;
            }
        }
        private void RoundedCycleStop_Click(object sender, EventArgs e)
        {
            if (Options.PortState == true)
            {
                CycleSet.CycleStart = false;
                CycleSet.StopCycle();
                Excel.ExcelEndSave();
                labelCycle.Text = "-";
                Options.CycleCounter = 1;

                roundedCharge.Enabled = true;
                roundedDischarge.Enabled = true;
                roundedCycleStart.Enabled = true;
                roundedCycleStop.Enabled = false;
            }
        }
    }
}