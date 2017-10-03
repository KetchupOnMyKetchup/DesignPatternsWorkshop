using System;
using System.Composition;

namespace Mef2ConsoleApp
{

    [Export(typeof(IMessageSender))]
    public class EmailSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
