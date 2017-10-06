using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Contracts
{
    public interface IMessageManager
    {
        event EventHandler<NewMesageEventArgs> SendNewMessageEvent;
        string Sender { get; set; }
        string Recipient { get; set; }
        string Subject { get; set; }
        string Body { get; set; }
        void SendMessage(string sender, string recepient, string subject, string message);
    }

}
