using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDemo.Controllers
{
    public class MoodIndicatorController
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
            Console.WriteLine("Mood Indicator Switched {0}", status);
        }
    }
}
