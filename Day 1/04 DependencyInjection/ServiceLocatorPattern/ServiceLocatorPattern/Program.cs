namespace ServiceLocatorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Build centralized container that manages dependencies
            IServiceLocator locator = new ServiceLocator();
            
            // Dependent class requests dependency object from container
            // Key point: Caller explicitly initiates call - not injected
            // the following 2 calls creates an instance of the service,
            // as service is lazy-loaded.
            var serviceA = locator.GetService<IServiceA>();
            var serviceB = locator.GetService<IServiceB>();

            // this call grabs the already-instantiated service.
            var serviceA2 = locator.GetService<IServiceA>();
        }
    }
}