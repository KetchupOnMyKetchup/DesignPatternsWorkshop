using System;
using Observer.Contracts;

namespace Observer
{
 public class MessageManager : IMessageManager
    {
        public event EventHandler<NewMesageEventArgs> SendNewMessageEvent;
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public void SendMessage(string sender, string recepient, string subject, string message)
        {
            throw new NotImplementedException();
        }
    }
}
