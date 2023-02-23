using System; 
using System.Windows.Forms;

namespace Batteriest
{
    public partial class FormStatus : Form
    {
        public FormStatus()
        {
            InitializeComponent();
            
        }

        //Manuel Röle Kontrolü//
        private void RoundedCharge_Click(object sender, EventArgs e)
        {
            if (Options.PortState == true)
            {
                Options.Status = 1;
                SerialPortCom.SerialPort_WriteData();

                if (Excel.StartSavingExcel == false)
                {
                    Excel.ExcelStartSave();
                    Excel.StartSavingExcel = true;
                }

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
                Options.Status = 2;
                SerialPortCom.SerialPort_WriteData();

                if (Excel.StartSavingExcel == false)
                {
                    Excel.ExcelStartSave();
                    Excel.StartSavingExcel = true;
                }

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
                Options.Status = 0;
                SerialPortCom.SerialPort_WriteData();

                if (Excel.StartSavingExcel == true)
                {
                    Excel.ExcelEndSave();

                    Excel.ExcelRestart();
                    Excel.StartSavingExcel = false;
                }

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
                Cycle.StartCycle();

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
                Cycle.CycleStart = false;
                Cycle.StopCycle();

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