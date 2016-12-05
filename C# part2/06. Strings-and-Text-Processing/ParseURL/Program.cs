using System;

namespace ParseURL
{
    class StartUp
    {
        static void Main()
        {
            string URL = Console.ReadLine();
            int index1 = URL.IndexOf("://");
            int index2 = URL.IndexOf('/', index1 + 3);
            Console.WriteLine("[protocol] = {0}", URL.Substring(0, index1));
            Console.WriteLine("[server] = {0}", URL.Substring(index1 + 3, index2 - index1 - 3));
            Console.WriteLine("[resource] = {0}", URL.Substring(index2, URL.Length - index2));
        }
    }
}
