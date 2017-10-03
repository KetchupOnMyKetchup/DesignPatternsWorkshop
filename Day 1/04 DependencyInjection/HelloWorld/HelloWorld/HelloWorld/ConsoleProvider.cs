using System;

namespace HelloWorld
{
    internal class ConsoleProvider : IMessageProvider
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}