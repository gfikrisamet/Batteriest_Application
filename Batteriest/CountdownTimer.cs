using System.Threading.Tasks;
using System.Timers;
namespace Batteriest
{
    public class CountdownTimer
    {
        public static Timer timer2;
        public static Timer timer3;
        public static Timer timer4;

        public static float countdownSeconds2;
        public static float countdownSeconds3;
        public static float countdownSeconds4;

        //TIMER FOR STAGE 2//
        public static void StartCountdownS2(float seconds)
        {
            countdownSeconds2 = seconds;

            timer2 = new Timer(1000);
            timer2.Elapsed += TimerElapsedS2;
            timer2.Start();
        }
        private static void TimerElapsedS2(object sender, ElapsedEventArgs e)
        {
            countdownSeconds2--;

            if (countdownSeconds2 > 0)
            {
                UpdateData.UpdateRCStage2('W');
            }
            else
            {
                timer2.Stop();
                UpdateData.UpdateRCStage2('D');
                timer2.Dispose();
            }
        }
        //END CODE//

        //TIMER FOR STAGE 3//
        public static void StartCountdownS3(float seconds)
        {
            countdownSeconds3 = seconds;

            timer3 = new Timer(1000);
            timer3.Elapsed += TimerElapsedS3;
            timer3.Start();
        }
        private static void TimerElapsedS3(object sender, ElapsedEventArgs e)
        {
            countdownSeconds3--;

            if (countdownSeconds3 > 0)
            {
            }
            else
            {
                timer3.Stop();
                Excel.ExcelEndSave();
                Options.SP_State = 61;
                UpdateData.UpdateRCStage3();
                timer3.Dispose();
            }
        }
        //END CODE//

        //TIMER FOR STAGE 4//
        public static void StartCountdownS4(float seconds)
        {
            countdownSeconds4 = seconds;

            timer4 = new Timer(1000);
            timer4.Elapsed += TimerElapsedS4;
            timer4.Start();
        }
        private static void TimerElapsedS4(object sender, ElapsedEventArgs e)
        {
            countdownSeconds4--;

            if (countdownSeconds4 > 0)
            {
            }
            else
            {
                timer4.Stop();
                Options.SP_State = 61;

                timer4.Dispose();
            }
        }
        //END CODE//
        public static async Task DelaySeconds(int miliseconds)
        {
            await Task.Delay(miliseconds);
        }
    }
}