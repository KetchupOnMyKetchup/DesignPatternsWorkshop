using System;

namespace Observer
{
    public sealed class NewMesageEventArgs : EventArgs
    {
        public NewMesageEventArgs(string sender, string recepient, string subject, string message)
        {
            Sender = sender;
            Recipient = recepient;
            Subject = subject;
            Message = message;
        }

        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}