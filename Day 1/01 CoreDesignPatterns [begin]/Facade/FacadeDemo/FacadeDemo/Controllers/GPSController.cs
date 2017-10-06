using System;

namespace FacadeDemo.Controllers
{
    internal class GPSController
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

        public bool LoadMap(string mapName)
        {
            Console.WriteLine("Loaded Map {0}", mapName);
            return true;
        }

        private void DisplayStatus()
        {
            var status = (_isSwitchedOn) ? "ON" : "OFF";
            Console.WriteLine("GPS Switched {0}", status);
        }
    }
}