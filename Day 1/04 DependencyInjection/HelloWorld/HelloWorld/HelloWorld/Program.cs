using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var program = new Program();
            program.LogMessage();
            Console.ReadLine();
        }

        private void LogMessage()
        {
            // call static version
            var staticProvider = new StaticProvider();
            staticProvider.Write("Logging this 1st system message");

            // call dynamic version that implements dependency injection
            // inject consoleProvider instance 
            var consoleProvider = new DynamicProvider(new ConsoleProvider());
            consoleProvider.WriteMessage("Logging this 2nd system message");

            var databaseProvider = new DynamicProvider(new DatabaseProvider());
            // inject databaseProvider instance 
            databaseProvider.WriteMessage("Logging this 3rd system message");

            var xmlProvider = new DynamicProvider(new XMLProvider());
            // inject xmlProvider instance 
            xmlProvider.WriteMessage("Logging this 4th system message");
        }
    }
}