using System;
using System.Collections.Generic;
using System.Text;

namespace _10_4Lab
{
    class Artist : IAudioPlayer
    {
        public string artistName { get; }
        public Dictionary<int, string> playlist;


        public Artist(string artistName )
        {
            this.artistName = artistName;
            playlist = new Dictionary<int, string>();
        }

        public void AddToPlaylist(string songTitle)
        {
            int id = playlist.Count;
            playlist.Add(id, songTitle);
        }

        public void Play()
        {
            Random random = new Random();
            int songId = random.Next(0, playlist.Count);
            StringBuilder sb = new StringBuilder();
            sb.Append("Now Playing Artist: ");
            sb.Append(artistName);
            sb.Append(" Song: ");
            sb.Append(playlist[songId]);
            Console.WriteLine(sb.ToString());
        }
    }
}
