using System;

namespace Singleton
{
    internal class SingletonLauncher
    {
        private static void Main(string[] args)
        {
            var user1 = LoggingService.Instance;
            Console.WriteLine(user1.LogMessage("First Message to Log"));

            var user2 = LoggingService.Instance;
            Console.WriteLine(user2.LogMessage("Second Message to Log"));

            var user3 = LoggingService.Instance;
            Console.WriteLine(user3.LogMessage("Third Message to Log"));

            Console.ReadLine();
        }
    }
}