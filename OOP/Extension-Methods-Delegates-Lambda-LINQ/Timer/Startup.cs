namespace Timer
{
    class Startup
    {
        static void Main()
        {
            System.Console.Write("Enter Interval in Seconds: ");
            int interval = int.Parse(System.Console.ReadLine());
            MyTimer.RunMethodInTime(MyTimer.TimerRunMethod, interval);
        }
    }
}
