using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework.DefiningClasses_Part1
{
    class GSMTest
    {
        static void Main()
        {
            GSM[] arr = new GSM[5];
            arr[0] = new GSM("GalaxyS7Edge", "Samsung", 1200, "Yoan");
            arr[1] = new GSM("UmiMax", "UMi", 260, "Emil");
            arr[2] = new GSM("GalaxyS4", "Samsung", 600, "Vesi");
            arr[3] = new GSM("GalaxyS3Mini", "Samsung", 400, "Emil");
            arr[4] = new GSM("GalaxyS5Mini", "Samsung", 550, "Pooh");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine();
            }
            GSM.iPhone4S = "Pere Noel";
            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine();
            Call[] calls = new Call[4];
            calls[0] = new Call(DateTime.Today.ToString("D"), DateTime.Now.ToString("HH:mm"), "+359898123456", 110);
            calls[1] = new Call(DateTime.Today.ToString("D"), DateTime.Now.ToString("HH:mm"), "+359898234567", 180);
            calls[2] = new Call(DateTime.Today.ToString("D"), DateTime.Now.ToString("HH:mm"), "+359898345678", 100);
            calls[3] = new Call(DateTime.Today.ToString("D"), DateTime.Now.ToString("HH:mm"), "+359898012345", 10);

            Double price = 0.37;

            GSMCallHistoryTest test = new GSMCallHistoryTest();

            GSM testedPhone = arr[1];

            foreach (var call in calls)
            {
                test.AddSomeCalls(testedPhone, call);
            }

            Console.WriteLine("{0}:", testedPhone.model);
            for (int i = 0; i < testedPhone.CallHistory.Count; i++)
            {
                test.InfoCall(testedPhone, i);
            }

            Console.WriteLine("Total call price {0}: {1:F} лв.", testedPhone.model, test.CalculateTotalPrice(testedPhone, price));
            test.RemoveLongestCall(testedPhone);
            Console.WriteLine("The longest call from the history removed.");
            Console.WriteLine("Total call price {0}: {1:F} лв.", testedPhone.model, test.CalculateTotalPrice(testedPhone, price));
            test.ClearCallHistory(testedPhone);

            if (testedPhone.CallHistory.Count == 0)
            {
                Console.WriteLine("No call history.");
            }
            else
            {
                Console.WriteLine("{0}:", testedPhone.model);
                for (int i = 0; i < testedPhone.CallHistory.Count; i++)
                {
                    test.InfoCall(testedPhone, i);
                }
            }
        }
    }
}
