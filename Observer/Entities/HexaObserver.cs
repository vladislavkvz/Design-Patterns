namespace Observer.Entities
{
    using System;

    public class HexaObserver : Observer
    {

        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Hex String: " + String.Format("{0:X}", subject.GetState()));
        }
    }
}