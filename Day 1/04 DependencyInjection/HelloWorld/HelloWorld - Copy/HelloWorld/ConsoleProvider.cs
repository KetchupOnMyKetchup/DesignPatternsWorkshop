using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ConsoleProvider : IMessageProvider
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
