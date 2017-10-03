using System;

namespace HelloWorld
{
    internal class DatabaseProvider : IMessageProvider
    {
        public void Write(string message)
        {
            // Code that writes message to database
            Console.WriteLine(message);
        }
    }
}