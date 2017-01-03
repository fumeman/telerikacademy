using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.DefiningClasses_Part1
{
    public class GSMCallHistoryTest
    {
        public GSM gsm;
        public Call call;

        public void AddSomeCalls(GSM gsm, Call call)
        {
            gsm.AddCall(call);
        }

        public void InfoCall(GSM gsm, int callNumber)
        {
            Console.WriteLine("Date: {0}, Time: {1}, Number: {2}, Duration: {3} seconds", gsm.callHistory[callNumber].date, gsm.callHistory[callNumber].time, gsm.callHistory[callNumber].dialledPhoneNumber, gsm.callHistory[callNumber].duration);
        }

        public Double CalculateTotalPrice(GSM gsm, Double price)
        {
            Double result = 0;
            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                result += gsm.CallPrice(i, price);
            }
            return result;
        }

        public void RemoveLongestCall(GSM gsm)
        {
            int longest = 0, index = 0, neededIndex = 0;
            foreach (var call in gsm.CallHistory)
            {
                if(longest < call.Duration)
                {
                    longest = call.Duration;
                    neededIndex = index;
                }
                index++;
            }
            gsm.DeleteCall(neededIndex);
        }

        public void ClearCallHistory(GSM gsm)
        {
            gsm.CallHistory.Clear();
        }

        public GSMCallHistoryTest()
        {

        }

        public GSMCallHistoryTest(GSM gsm, Call call)
        {
            this.gsm = gsm;
            this.call = call;            
        }

        public GSM GSM
        {
            get
            {
                return this.gsm;
            }
             set

            {
                this.gsm = value;
            }
        }

        public Call Call
        {
            get
            {
                return this.call;
            }
            set
            {
                this.call = value;
            }
        }
    }
}
