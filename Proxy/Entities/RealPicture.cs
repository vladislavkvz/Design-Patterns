namespace Proxy.Entities
{
    using Interfaces;
    using System;

    public class RealPicture : IPicture
    {
        private string fileName;
        public RealPicture(string fileName)
        {
            this.fileName = fileName;
            LoadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying " + fileName);
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }
}