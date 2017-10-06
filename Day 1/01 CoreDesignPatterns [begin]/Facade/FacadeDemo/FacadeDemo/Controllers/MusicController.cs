using System;

namespace FacadeDemo.Controllers
{
    public class MusicController
    {
        private bool _isSwitchedOn;

        public bool IsSwitchedOn
        {
            get { return _isSwitchedOn; }
            set
            {
                _isSwitchedOn = value;
                DisplayStatus();
            }
        }

        public bool Start()
        {
            Console.WriteLine("Playing Playlist");
            return true;
        }

        private void DisplayStatus()
        {
            var status = (_isSwitchedOn) ? "ON" : "OFF";
            Console.WriteLine("Music Switched {0}", status);
        }

        public bool LoadPlaylist(string playlist)
        {
            Console.WriteLine("Loading Playlist {0}", playlist);
            return true;
        }
    }
}