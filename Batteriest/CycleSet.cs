namespace Batteriest
{
    public class CycleSet
    {
        public static bool CycleStart = false;
        public static void StartCycle()
        {
            if (Options.PortState == true)
            {
                CycleStart = true;
                Options.CycleCounter = 1;
                SerialPortCom.SerialPort_WriteData("charge");
            }
        }
        public static void StopCycle()
        {
            if (Options.PortState == true)
            {
                CycleStart = false;
                SerialPortCom.SerialPort_WriteData("idle");
            }
        }
    }
}
