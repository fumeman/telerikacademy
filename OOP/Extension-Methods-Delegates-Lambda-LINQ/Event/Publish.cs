namespace Events
{
    using System;

    public class Publish
    {
        public event EventHandler<PersonalEvent> PublicEvent;

        public void WriteOnScreen()
        {
            this.OnPublicEvent(new PersonalEvent("Some text here!"));
        }

        protected virtual void OnPublicEvent(PersonalEvent e)
        {
            EventHandler<PersonalEvent> handler = this.PublicEvent;
            if (handler != null)
            {
                e.Message += string.Format($" at {DateTime.Now.ToString()}");
                handler(this, e);
            }
        }
    }
}