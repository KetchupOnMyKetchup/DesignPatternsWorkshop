using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HelloWorldDynamic
    {
        private readonly IMessageProvider _messageProvider;

        internal HelloWorldDynamic(IMessageProvider messageProvider)
        {
            _messageProvider = messageProvider;
        }

        internal void SayHello(string message)
        {
            _messageProvider.Write(message);
        }
    }
}
