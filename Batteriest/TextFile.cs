using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Batteriest
{
    public static class TextFile
    {
        public static int fileCounter = 1;
        public static string SelectedFileNameWithoutExtension = "Pulse_Discharge_Test_";
        public static string SelectedExtension = ".txt";
        public static string SelectedDirectory = Excel.SelectedDirectory;
        public static string SelectedFilePath = Path.Combine(Excel.SelectedDirectory, string.Format(SelectedFileNameWithoutExtension + fileCounter + SelectedExtension));
        public static int sample;



        public static bool isLogging = false;
        public static StreamWriter logFileWriter = new StreamWriter(SelectedFilePath);

        public static void RestartLogging(string testName)
        {
            isLogging = false;
            SelectedFileNameWithoutExtension = testName;
            SelectedFilePath = Path.Combine(Excel.SelectedDirectory, string.Format(SelectedFileNameWithoutExtension + fileCounter + SelectedExtension));
            logFileWriter = new StreamWriter(SelectedFilePath);
        }

        public async static void StartLogging(string testName)
        {
            isLogging = true;
            SerialPortCom.SerialPort_WriteData("discharge_m2");

            await CountdownTimer.DelaySeconds(1000);

            Options.SP_State = 4;

            switch (testName)
            {

                case "PDT":
                    sample = Convert.ToInt32(Options.RCHighSSample * 1000);
                    await CountdownTimer.DelaySeconds(sample);

                    SerialPortCom.SerialPort_WriteData("discharge_m1");
                    sample = Convert.ToInt32(Options.RCLowSSample * 1000);

                    await CountdownTimer.DelaySeconds(sample);
                    break;

                case "HAT":
                    await CountdownTimer.DelaySeconds(Options.HASampleTime);
                    break;
            }

            StopLogging();
        }
        public async static void StopLogging()
        {
            Options.SP_State = 61;
            await CountdownTimer.DelaySeconds(1000);
            SerialPortCom.SerialPort_WriteData("idle");
            await CountdownTimer.DelaySeconds(1000);

            isLogging = false;
            logFileWriter.Close();
            logFileWriter.Dispose();

            if (SelectedFileNameWithoutExtension == "Pulse_Discharge_Test_")
            {
                UpdateData.UpdateRCStage4();
                TexttoExcel.ConvertTxtToExcel("PDT");
            }
            else if (SelectedFileNameWithoutExtension == "Harmonic_Analysis_Test_")
            {
                UpdateData.UpdateHAStage1();
                TexttoExcel.ConvertTxtToExcel("HAT");
                UpdateData.UpdateHAStage2();
                var settings3watch = Stopwatch.StartNew();
                while (settings3watch.Elapsed.TotalSeconds < 3)
                {
                    Application.DoEvents();
                }
                UpdateData.UpdateHADone();
            }
        }
    }
}
