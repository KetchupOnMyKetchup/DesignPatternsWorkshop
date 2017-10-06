using Strategies.Contracts;

namespace Strategies.Strategies
{
    internal class DogQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "Quack Like Dog";
        }
    }
}