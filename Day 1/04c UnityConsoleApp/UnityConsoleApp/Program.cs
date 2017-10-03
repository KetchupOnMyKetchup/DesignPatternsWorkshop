using System;
using Microsoft.Practices.Unity;
using UnityConsoleApp.Interfaces;

namespace UnityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            Container.RegisterElements(container);

            IAdapter adapter = container.Resolve<IAdapter>();
            Console.WriteLine(adapter.Voltage());

            TVStand tvStand = container.Resolve<TVStand>();
            Console.WriteLine(tvStand.MaxInchesOfTVOnStand());

            IRemote remote = container.Resolve<IRemote>();
            ITelevision television = container.Resolve<ITelevision>
                (new ParameterOverride("adapter", adapter),
                new ParameterOverride("remote", remote),
                new ParameterOverride("manufacturer", "Visio"),
                new ParameterOverride("modelNumber", "321asdf"));


            television.TurnOn();

            Console.ReadLine();

            ISpeaker cheapSpeaker = container.Resolve<ISpeaker>("Cheap");
            ISpeaker priceySpeaker = container.Resolve<ISpeaker>("Expensive");
            cheapSpeaker.Start();
            priceySpeaker.Start();

            Console.ReadLine();

            IBox casing = container.Resolve<IBox>();
            Console.WriteLine(casing.TypeOfMaterial());

            Console.ReadLine();

        }
    }
}
