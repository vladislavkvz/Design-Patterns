namespace Adapter.Entities
{
    using System;
    using Interfaces;

    public class Mp4Player : IAdvancedPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file: " + fileName);
        }

        public void playVlc(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}