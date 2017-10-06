using System;
using Observer.Contracts;

namespace Observer
{
 public class MessageManager : IMessageManager
    {
        public MessageManager() {}
        
        //Declare event
        //Use built-in EventHandler delegate
        public event EventHandler<NewMesageEventArgs> SendNewMessageEvent;
        
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
 
        public void SendMessage(string sender, string recepient, string subject, string message)
        {
            Sender = sender;
            Recipient = recepient;
            Subject = subject;
            Body = message;

            //Construct object that contains email information that we pass to subscribers
            var e = new NewMesageEventArgs(sender, recepient, subject, message);

            //Raise the event to notify subscribers
            OnSendNewMessage(e);
       }

       protected virtual void OnSendNewMessage(NewMesageEventArgs e)
       {
           // Always ensure that someone is listening before raising event
           if (SendNewMessageEvent != null)
               SendNewMessageEvent(this, e);
       }
    }
}
