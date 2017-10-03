namespace ServiceLocatorPattern
{
    internal interface IServiceLocator
    {
        T GetService<T>();
    }
}