namespace Events
{
    using System;

    public class Recipient
    {
        private string name;

        public Recipient(string name, Publish something)
        {
            this.name = name;
            something.PublicEvent += this.EventHandler;
        }

        void EventHandler(object sender, PersonalEvent e)
        {
            Console.WriteLine($"Message to {name}: {e.Message}");
        }
    }
}