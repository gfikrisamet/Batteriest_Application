using System.Globalization;

namespace Batteriest
{
    public class Options
    {
        public static bool Mov;
        public static int MovX;
        public static int MovY;

        public static FormPulseDischarge formRC = new FormPulseDischarge();
        public static FormAgingTest formAging = new FormAgingTest();
        public static FormHarmonicAnalysis formHarmonic = new FormHarmonicAnalysis();
        public static FormAboutUs formAbout = new FormAboutUs();

        public static float RCVoltage = 4.05F;
        public static float RCRestTime = 60;
        public static float RCHighSSample = 15;
        public static float RCLowSSample = 85;

        public static float ATMaxVoltage = 4.2F;
        public static float ATMinVoltage = 2.7F;
        public static float ATCycle = 200;

        public static int HASampleTime = 20;

        public static float SMaxVoltage = 4.25F;
        public static float SMinVoltage = 2.65F;
        public static float SMaxTemp = 45;

        public static CultureInfo cultureInfo = new CultureInfo("en-US");

        public static string PortName = "COM1";
        public static bool PortState = false;
        public static bool RC_Stage1 = false;
        public static bool SavedSettings = false;

        public static int SP_State = 61;


        public static int CycleCounter = 1;
    }
}
