namespace Events
{
    using System;
    using System.Threading;

    class Startup
    {
        static void Main()
        {
            Console.Write("Time Interval in Seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            if (seconds > 0)
            {
                Publish something = new Publish();
                Recipient me = new Recipient("Me", something);

                while (true)
                {
                    something.WriteOnScreen();
                    Thread.Sleep(seconds * 1000);
                }
            }
        }
    }
}