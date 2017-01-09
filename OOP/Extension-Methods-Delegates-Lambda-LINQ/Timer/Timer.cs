namespace Timer
{
    using System;
    using System.Threading;

    public delegate void RunMethod(int seconds);

    public class MyTimer
    {
        public static void RunMethodInTime(RunMethod myMethod, int seconds)
        {
            if (seconds > 0)
            {
                while (true)
                {
                    myMethod(seconds);
                    Thread.Sleep(seconds * 1000);
                }
            }
        }

        public static void TimerRunMethod(int seconds)
        {
            Console.WriteLine($"Started by timer every {seconds} {(seconds == 1 ? "second" : "seconds")}");
        }
    }
}
