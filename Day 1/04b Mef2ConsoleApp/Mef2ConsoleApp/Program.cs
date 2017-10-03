using System;
using System.Composition;
using System.Composition.Hosting;
using System.Reflection;

namespace Mef2ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        public void Run()
        {
            Compose();
            MessageSender.Send("Hello MEF");
            Console.ReadLine();
        }

        [Import]
        public IMessageSender MessageSender { get; set; }
        private void Compose()
        {
            var assemblies = new[] { typeof(Program).GetTypeInfo().Assembly };
            var configuration = new ContainerConfiguration()
                .WithAssembly(typeof(Program).GetTypeInfo().Assembly);
            using (var container = configuration.CreateContainer())
            {
                MessageSender = container.GetExport<IMessageSender>();
            }
        }
    }
}
