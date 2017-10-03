using System;
using System.Collections.Generic;
using System.Text;

namespace Mef2ConsoleApp
{
    public interface IMessageSender
    {
        void Send(string message);
    }
}
