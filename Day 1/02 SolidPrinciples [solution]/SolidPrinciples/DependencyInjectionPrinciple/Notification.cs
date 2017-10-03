using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInjectionPrinciple
{

    public class Notification
    {
        private IMessenger _iMessenger;
        public Notification()
        {
            _iMessenger = new Email();
        }
        public void DoNotify()
        {
            _iMessenger.SendMessage();
        }
    }


}
