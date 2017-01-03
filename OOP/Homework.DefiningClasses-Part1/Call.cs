namespace Homework.DefiningClasses_Part1
{ 
    public class Call
    {
        public string date;
        public string time;
        public string dialledPhoneNumber;
        public int duration;

        public Call()
        {
        }

        public Call(string date, string time, string dialledPhoneNumber, int duration)
        {
            this.date = date;
            this.time = time;
            this.dialledPhoneNumber = dialledPhoneNumber;
            this.duration = duration;
        }

        public string Date
        {
            get
            {

                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            set
            {
                this.dialledPhoneNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }
    }
}
