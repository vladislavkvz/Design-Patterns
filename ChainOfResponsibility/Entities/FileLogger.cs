namespace ChainOfResponsibility.Entities
{
    using System;

    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }
        protected override void Write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}