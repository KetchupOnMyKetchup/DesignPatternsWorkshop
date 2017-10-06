namespace Decorator
{
    /// <summary>
    /// Provides the base type for concrete cars and concrete car options
    /// </summary>
    public abstract class Car
    {
        public abstract double Cost { get; }
        public abstract string Description { get; }
        public abstract void Purchase();
    }
}