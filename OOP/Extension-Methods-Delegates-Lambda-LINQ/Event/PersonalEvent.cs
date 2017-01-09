namespace Events
{
    using System;

    public class PersonalEvent : EventArgs
    {
        private string message;

        public PersonalEvent(string str)
        {
            this.message = str;
        }

        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }
    }
}