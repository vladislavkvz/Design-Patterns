﻿namespace ChainOfResponsibility.Entities
{
    using System;

    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            this.level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Standard Console::Logger: " + message);
        }
    }
}