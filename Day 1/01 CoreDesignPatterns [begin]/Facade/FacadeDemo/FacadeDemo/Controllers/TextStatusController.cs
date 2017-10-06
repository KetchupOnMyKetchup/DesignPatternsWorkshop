using System;

namespace FacadeDemo.Controllers
{
    public class TextStatusController
    {
        private bool _setToAway;
        public bool SetToAway
        {
            get { return _setToAway; }
            set
            {
                _setToAway = value;
                DisplayStatus();
            }
        }

        private void DisplayStatus()
        {
            var status = (_setToAway) ? "Away" : "Available";
            Console.WriteLine("Text Status Set to  {0}", status);
        }
    }
}
