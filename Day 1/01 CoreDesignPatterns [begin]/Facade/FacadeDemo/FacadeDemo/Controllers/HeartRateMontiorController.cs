using System;

namespace FacadeDemo.Controllers
{
    public class HeartRateMontiorController
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

        public bool Pair()
        {
            Console.WriteLine("Heart Rate Monitor Switched");
            return true;
        }
        
        public bool Start()
        {
            Console.WriteLine("Heart Rate Monitor Started");
            return true;
        }        
        
        public bool Stop()
        {
            Console.WriteLine("Heart Rate Monitor Stopped");
            return true;
        }

        private void DisplayStatus()
        {
            var status = (_isSwitchedOn) ? "ON" : "OFF";
            Console.WriteLine("Heart Rate Monitor Switched {0}", status);
        }


    }
}
