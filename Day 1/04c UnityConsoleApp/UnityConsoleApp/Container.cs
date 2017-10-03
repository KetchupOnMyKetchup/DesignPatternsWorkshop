using Microsoft.Practices.Unity;
using UnityConsoleApp.Implementations;

namespace UnityConsoleApp
{
    public class Container
    {
        public static void RegisterElements(IUnityContainer container)
        {
            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default,
                WithLifetime.ContainerControlled);

            TVStand tvStand = new TVStand(70);
            container.RegisterInstance(tvStand);

            container.RegisterType<ISpeaker, WalmartSpeaker>("Cheap");
            container.RegisterType<ISpeaker, BoseSpeaker>("Expensive");
            //container.RegisterType<Box>(new InjectionConstructor("Cardboard"));
        }
    }
}
