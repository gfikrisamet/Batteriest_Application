using System;
using System.Windows.Forms;

namespace Batteriest
{
    public partial class FormHarmonicAnalysis : Form
    {
        public FormHarmonicAnalysis()
        {
            InitializeComponent();
        }

        private void RoundedHAStartButton_Click(object sender, EventArgs e)
        {
            if (Options.PortState == true)
            {
                TextFile.RestartLogging("Harmonic_Analysis_Test_");
                roundedHAStartButton.Enabled = false;
                TextFile.StartLogging("HAT");

            }
            else
            {
                MessageBox.Show("It does not connect the serial port!", "Error");
            }
        }
    }
}
