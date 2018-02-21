namespace Adapter
{
    using Entities;
    using Interfaces;

    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedPlayer player;

        public MediaAdapter(string audioType)
        {
            if (audioType == "vlc")
            {
                player = new VlcPlayer();
            }
            else if (audioType == "mp4")
            {
                player = new Mp4Player();
            }
        }

        public void Play(string audioType, string file)
        {
            if (audioType == "vlc")
            {
                player.playVlc(file);
            }
            else if (audioType == "mp4")
            {
                player.playMp4(file);
            }
        }
    }
}