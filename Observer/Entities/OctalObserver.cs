﻿namespace Observer.Entities
{
    using System;

    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + Convert.ToString(subject.GetState(), 8));
        }
    }
}