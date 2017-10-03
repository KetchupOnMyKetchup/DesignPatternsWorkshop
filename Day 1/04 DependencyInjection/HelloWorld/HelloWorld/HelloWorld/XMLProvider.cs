using System;

namespace HelloWorld
{
    internal class XMLProvider : IMessageProvider
    {
        public void Write(string message)
        {
            // Write message to XML file
            Console.WriteLine(message);
        }
    }
}