using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.SayHello();
        }

        private void SayHello()
        {
            // Call static version
            new HelloWorldStatic().SayHello("Hello World");
            
            // Call dynamic version that implements dependency injection
            new HelloWorldDynamic(new ConsoleProvider()).SayHello("Hello World");
            new HelloWorldDynamic(new DatabaseProvider()).SayHello("Hello World");
            new HelloWorldDynamic(new XMLProvider()).SayHello("Hello World");
        }
    }
}
