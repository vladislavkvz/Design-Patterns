namespace Adapter.Entities
{
    using System;
    using Interfaces;

    public class VlcPlayer : IAdvancedPlayer
    {
        public void playMp4(string fileName)
        {
            throw new NotImplementedException();
        }

        public void playVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file: " + fileName);
        }
    }
}