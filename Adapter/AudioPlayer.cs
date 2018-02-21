namespace Adapter
{
    using Interfaces;
    using System;

    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter adapter;

        public void Play(string audioType, string file)
        {
            if (audioType == "mp3")
            {
                Console.WriteLine("Playing mp3 file: " + file);
            } else if (audioType == "vlc" || audioType == "mp4")
            {
                adapter = new MediaAdapter(audioType);
                adapter.Play(audioType, file);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported!");
            }
        }
    }
}