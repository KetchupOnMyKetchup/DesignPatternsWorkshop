using System;
using System.Threading;
using Observer.Contracts;

namespace Observer.Providers
{
    public class EmailClientProvider : IMessageProvider
    {
        public string Message { get; private set; }
        private readonly IMessageManager _messageManager;

        public EmailClientProvider(IMessageManager messageManager)
        {
            _messageManager = messageManager;
        }

        public void SendMessage(object sender, NewMesageEventArgs e)
        {
            //Implementation for sending text message
            Message = string.Format("{0}: From {1}, to {2}, Sending Email: {3}", "Email", e.Sender, e.Recipient, e.Message);
            Console.WriteLine(Message);
            Console.WriteLine(Environment.NewLine);
        }

        public void Subscribe()
        {
            //Register eventHandler with publisher (a.k.a. Subject)
            //This action subscribes the eventHandler to the publisher's sendNewMessage event
            _messageManager.SendNewMessageEvent += SendMessage;          
        }

        public void Unsubscribe()
        {
            //This action unsubscribes the eventHandler to the publisher's sendNewMessage event
            _messageManager.SendNewMessageEvent -= SendMessage;
            Message = null;
        }
    }

}
