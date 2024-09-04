using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Batteriest
{
    public class SerialPortCom
    {
        public static SerialPort mySerialPort;
        public static string PortName = "COM1";

        public static string voltage;
        public static string current;
        public static string temp;
        public static string cycle;
        public static string serialData;
        public static string[] serialDataArray;


        public static float floatstatus;
        public static float floatvolt;
        public static float floatcurrent;
        public static float floattemp;

        public static void ConnectToSerialPort()
        {
            try
            {
                mySerialPort = new SerialPort(SerialPortCom.PortName)
                {
                    BaudRate = 2000000,
                    Parity = Parity.None,
                    StopBits = StopBits.One,
                    DataBits = 8,
                    Handshake = Handshake.None,
                    RtsEnable = true
                };
                mySerialPort.Open();
                Options.PortState = true;
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_ReceivedData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void DisconnectToSerialPort(char DSP_State)
        {
            SerialPort_WriteData("idle");
            Options.PortState = false;
            switch (DSP_State)
            {
                case 'R':
                    mySerialPort.DataReceived -= new SerialDataReceivedEventHandler(SerialPort_ReceivedData);
                    UpdateData.UpdateRCValueLabels("-", "-");
                    if (Options.formRC.pictureStage2.BackColor == Color.Yellow)
                    {
                        Options.formRC.labelRC_Second.ForeColor = Color.White;
                        CountdownTimer.countdownSeconds2 = 0;
                        CountdownTimer.timer2.Stop();
                        CountdownTimer.timer2.Dispose();
                    }
                    if (Options.formRC.pictureStage2.BackColor == Color.Green)
                    {
                        Excel.ExcelEndSave();
                    }
                    if (Options.formRC.pictureStage3.BackColor == Color.Green)
                    {
                        TextFile.StopLogging();
                    }
                    Options.SP_State = 61;
                    Options.formRC.roundedPDStartButton.Enabled = true;
                    UpdateData.UpdateRCDone();

                    break;
                case 'A':
                    mySerialPort.DataReceived -= new SerialDataReceivedEventHandler(SerialPort_ReceivedData);
                    UpdateData.UpdateATValueLabels("-", "-", "-");
                    UpdateData.UpdateCycleLabel("-");
                    break;
            }
            System.Threading.Thread.Sleep(1000);
            mySerialPort.Close();
        }

        public static void SerialPort_ReceivedData(object sender, SerialDataReceivedEventArgs e)
        {
            switch (Options.SP_State)
            {
                case 1:
                    serialDataArray = mySerialPort.ReadLine().Split(',');

                    voltage = serialDataArray[1];
                    current = serialDataArray[2];

                    floatvolt = float.Parse(voltage, Options.cultureInfo);
                    floatcurrent = float.Parse(current, Options.cultureInfo);

                    UpdateData.UpdateRCValueLabels(voltage, current);

                    if (floatvolt < Options.RCVoltage && Options.RC_Stage1 == false)
                    {
                        UpdateData.UpdateRCStage1('C');
                    }
                    else
                    {
                        UpdateData.UpdateRCStage1('I');
                        Options.RC_Stage1 = true;
                    }
                    break;
                case 2:
                    serialDataArray = mySerialPort.ReadLine().Split(',');

                    voltage = serialDataArray[1];
                    current = serialDataArray[2];

                    floatvolt = float.Parse(voltage, Options.cultureInfo);
                    floatcurrent = float.Parse(current, Options.cultureInfo);
                    Excel.ExcelData("RC");
                    break;
                case 3:
                    serialDataArray = mySerialPort.ReadLine().Split(',');

                    voltage = serialDataArray[1];
                    current = serialDataArray[2];
                    temp = serialDataArray[3];

                    floatvolt = float.Parse(voltage, Options.cultureInfo);
                    floatcurrent = float.Parse(current, Options.cultureInfo);
                    //floattemp = float.Parse(temp, Options.cultureInfo);

                    if (Excel.StartSavingExcel == true)
                    {
                        Excel.ExcelData("AT");
                    }
                    UpdateData.UpdateATValueLabels(voltage, current, temp);

                    if (CycleSet.CycleStart == true)
                    {
                        cycle = Options.CycleCounter.ToString();
                        UpdateData.UpdateCycleLabel(cycle);

                        if (floatvolt >= Options.ATMaxVoltage)
                        {
                            SerialPort_WriteData("discharge_m1");

                        }
                        if (floatvolt <= Options.ATMinVoltage)
                        {
                            Options.CycleCounter++;
                            if (Options.CycleCounter == Options.ATCycle + 1)
                            {
                                SerialPort_WriteData("idle");
                                CycleSet.CycleStart = false;
                                Excel.StartSavingExcel = false;
                                Excel.ExcelEndSave();
                                UpdateData.UpdateCycleLabel(cycle);
                                MessageBox.Show($"{Options.CycleCounter - 1} cycle has been successfully completed!");
                            }
                            else
                            {
                                SerialPort_WriteData("charge");
                            }
                        }
                    }
                    break;
                case 4:
                    serialData = mySerialPort.ReadExisting();
                    TextFile.logFileWriter.Write(serialData);
                    break;
                case 5:
                    serialDataArray = mySerialPort.ReadLine().Split(',');

                    voltage = serialDataArray[1];
                    current = serialDataArray[2];
                    UpdateData.UpdateATValueLabels(voltage, current, "-");
                    break;
            }


            /*
            if (Options.RC_Active == true)
            {
                UpdateData.UpdateRCValueLabels(voltage, current);

                if(floatvolt < Options.RCVoltage)
                {
                    UpdateData.UpdateRCStage1(1);
                }
                else if(floatcurrent < Options.RCCurrent)
                {
                    UpdateData.UpdateRCStage1(2);
                    Options.RC_Stage1 = true;
                }
            }
            else if (Options.RC_State3 == true)
            {
               
            }
            else if (Options.AT_Active == true)
            {

            }
            */
            /*if(voltageExit >= Options.MaxVoltage || voltageExit <= Options.MinVoltage || tempExit >= Options.MaxTemp)
            {
                SerialPort_WriteData(0);
                MessageBox.Show("Test has been stopped for security!");
            }
            if (Cycle.CycleStart == true)
            {
                cycle = Options.CycleCounter.ToString();
                Batteriest.UpdateCycleLabel(cycle);

                if (voltageExit >= Options.MaxVoltage)
                {
                    SerialPort_WriteData(2);
                }

                if (voltageExit <= Options.MinVoltage)
                {
                    Options.CycleCounter++;
                    if (Options.CycleCounter == Options.Cycle + 1)
                    {
                        SerialPort_WriteData(0);

                        Cycle.CycleStart = false;

                        Batteriest.UpdateCycleButtons();
                        MessageBox.Show($"{Options.CycleCounter - 1} cycle has been successfully completed!");
                    }
                    else
                    {
                        SerialPort_WriteData(1);
                    }
                }
            }*/
        }
        public static void SerialPort_WriteData(string Status)
        {
            switch (Status)
            {
                case "charge":
                    mySerialPort.Write("charge");
                    break;
                case "discharge_m1":
                    mySerialPort.Write("discharge_m1");
                    break;
                case "discharge_m2":
                    mySerialPort.Write("discharge_m2");
                    break;
                case "idle":
                    mySerialPort.Write("idle");
                    break;
            }
        }
    }
}
