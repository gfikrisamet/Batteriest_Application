using System.Drawing;
using System.Windows.Forms;

namespace Batteriest
{
    public static class UpdateData
    {
        public static void UpdateATValueLabels(string voltage, string current, string temp)
        {
            Options.formAging.labelVoltage.Invoke((MethodInvoker)delegate
            {
                Options.formAging.labelVoltage.Text = voltage;
                Options.formAging.labelCurrent.Text = current;
                Options.formAging.labelTemp.Text = temp;
            });
        }
        public static void UpdateCycleLabel(string cycle)
        {
            Options.formAging.labelCycle.Invoke((MethodInvoker)delegate
            {
                Options.formAging.labelCycle.Text = cycle;
            });
        }
        public static void UpdateCycleButtons()
        {
            Options.formAging.Invoke((MethodInvoker)delegate
            {
                Options.formAging.roundedCharge.Enabled = true;
                Options.formAging.roundedDischarge.Enabled = true;
                Options.formAging.roundedIdle.Enabled = false;
                Options.formAging.roundedCycleStart.Enabled = true;
                Options.formAging.roundedCycleStop.Enabled = false;
            });
        }
        public static void UpdateRCValueLabels(string voltage, string current)
        {
            Options.formRC.Invoke((MethodInvoker)delegate
            {
                Options.formRC.labelRC_CVoltage.Text = voltage;
                Options.formRC.labelRC_CCurrent.Text = current;
            });
        }
        public static void UpdateRCStage1(char stage1_Status)
        {
            switch (stage1_Status)
            {
                case 'C':
                    Options.formRC.Invoke((MethodInvoker)delegate
                    {
                        Options.formRC.labelRC_CStart.Text = "Charging!";
                        Options.formRC.labelRC_CStart.ForeColor = Color.FromArgb(0, 173, 181);
                        Options.formRC.pictureStage1.BackColor = Color.Yellow;
                    });
                    break;
                case 'I':
                    Options.formRC.Invoke((MethodInvoker)delegate
                    {
                        Options.formRC.labelRC_CStart.Text = "Charged!";
                        Options.formRC.labelRC_CStart.ForeColor = Color.Green;
                        Options.formRC.pictureStage1.BackColor = Color.Green;
                    });
                    break;
            }
        }
        public static void UpdateRCStage2(char stage2_Status)
        {
            switch (stage2_Status)
            {
                case 'W':
                    Options.formRC.Invoke((MethodInvoker)delegate
                    {
                        Options.formRC.labelRC_Second.Text = CountdownTimer.countdownSeconds2.ToString() + " Seconds";
                        Options.formRC.pictureStage2.BackColor = Color.Yellow;
                    });
                    break;
                case 'D':
                    Options.formRC.Invoke((MethodInvoker)delegate
                    {
                        Options.formRC.labelRC_Second.Text = "Done!";
                        Options.formRC.labelRC_Second.ForeColor = Color.Green;
                        Options.formRC.pictureStage2.BackColor = Color.Green;
                    });
                    break;
            }
        }
        public static void UpdateRCStage3()
        {
            Options.formRC.Invoke((MethodInvoker)delegate
            {
                Options.formRC.pictureStage3.BackColor = Color.Green;
            });
        }
        public static void UpdateRCStage4()
        {
            Options.formRC.Invoke((MethodInvoker)delegate
            {
                Options.formRC.pictureStage4.BackColor = Color.Green;
            });
        }
        public static void UpdateRCDone()
        {
            Options.formRC.Invoke((MethodInvoker)delegate
            {
                Options.formRC.labelRC_CStart.Text = "";
                Options.formRC.labelRC_Second.Text = "";
                Options.formRC.pictureStage1.BackColor = Color.White;
                Options.formRC.pictureStage2.BackColor = Color.White;
                Options.formRC.pictureStage3.BackColor = Color.White;
                Options.formRC.pictureStage4.BackColor = Color.White;
                Options.formRC.labelRC_Second.ForeColor = Color.White;
                Excel.ExcelRestart();

                MessageBox.Show("Pulse-Discharge Test has been successfully completed!", "Message");
            });
        }
        public static void UpdateHAStage1()
        {
            Options.formHarmonic.Invoke((MethodInvoker)delegate
            {
                Options.formHarmonic.pictureHAStage1.BackColor = Color.Green;
            });
        }
        public static void UpdateHAStage2()
        {
            Options.formHarmonic.Invoke((MethodInvoker)delegate
            {
                Options.formHarmonic.pictureHAStage2.BackColor = Color.Green;
            });
        }
        public static void UpdateHADone()
        {
            Options.formHarmonic.Invoke((MethodInvoker)delegate
            {
                Options.formHarmonic.pictureHAStage1.BackColor = Color.White;
                Options.formHarmonic.pictureHAStage2.BackColor = Color.White;
            });
            MessageBox.Show("Harmonic Analysis Test has been successfully completed!", "Message");
        }
    }
}