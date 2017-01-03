using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.DefiningClasses_Part1
{
    public class GSM
    {
        public string model;
        public string manufacturer;
        public int price;
        public string owner;
        public static string iPhone4S;
        public List<Call> callHistory = new List<Call>();

        Battery battery = new Battery();
        Display display = new Display();

        public Double CallPrice(int callNumber, Double callPrice)
        {
            return callHistory[callNumber].duration * (callPrice / 60);
        }

        public void DeleteCall(int callNumber)
        {
            callHistory.RemoveAt(callNumber);
        }

        public void AddCall(Call call)
        {
            callHistory.Add(call);
        }

        public override string ToString()
        {
            string result;
            result = String.Format(@"Manufacturer: {0}
Model: {1}
Price: {2}
Owner: {3}
", model, manufacturer, price, owner);
            result += battery.ToString() + display.ToString();
            return result;
        }

        public GSM()
        {
        }

        public GSM(string model, string manufacturer, int price = 0, string owner = "")
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        public static string IPhone4S
        {
            get
            {
                return GSM.iPhone4S;
            }
            set
            {
                GSM.iPhone4S = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Owner { get; set; }

        public void BatteryCharacteristics()
        {
            Battery battery = new Battery();
            Console.WriteLine(battery);
        }

        public void DisplayCharacteristics()
        {
            Display display = new Display();
            Console.WriteLine(display);
        }

        private class Display
        {
            internal int size;
            internal int numberOfColors;

            public override string ToString()
            {
                string result;
                result = String.Format(@"Display:
{0,14}
{1,26}
", "Size: " + size, "Number Of Colors: " + numberOfColors);
                return result;
            }

            internal Display()
            {

            }

            internal Display(int size = 0, int numberOfColors = 0)
            {
                this.size = size;
                this.numberOfColors = numberOfColors;
            }

            internal int Size
            {
                get
                {
                    return this.size;
                }
                set
                {
                    this.size = value;
                }
            }

            internal int NumberOfColors
            {
                get
                {
                    return this.numberOfColors;
                }

                set
                {
                    numberOfColors = value;
                }
            }
        }

        private class Battery
        {
            internal string model;
            internal int hoursIdle;
            internal int hoursTalk;

            public override string ToString()
            {
                string result;
                result = String.Format(@"Battery:
{0,14}
{1,20}
{2,20}
", "Model: " + model, "Hours Idle: " + hoursIdle, "Hours Talk: " + hoursTalk);
                return result;
            }

            internal Battery()
            {

            }

            internal Battery(string model = "", int hoursIdle = 0, int hoursTalk = 0)
            {
                this.model = model;
                this.hoursIdle = hoursIdle;
                this.hoursTalk = hoursTalk;
            }

            enum BatteryType
            {
                LiIon,
                NiMH,
                NiCd,
                Polymer,
                MgIon,
                LiAir
            }

            internal string Model
            {
                get
                {
                    return this.model;
                }
                set
                {
                    this.model = value;
                }
            }

            internal int HoursIdle
            {
                get
                {
                    return this.hoursIdle;
                }
                set
                {
                    this.hoursIdle = value;
                }
            }
            internal int HoursTalk
            {
                get
                {
                    return this.hoursTalk;
                }
                set
                {
                    this.hoursTalk = value;
                }
            }
        }
    }
}
