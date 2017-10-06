using System;

namespace FacadeDemo.Controllers
{
    public class WifiController
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

        private void DisplayStatus()
        {
            var status = (_isSwitchedOn) ? "ON" : "OFF";
            Console.WriteLine("WIFI Switched {0}", status);
        }
    }
}