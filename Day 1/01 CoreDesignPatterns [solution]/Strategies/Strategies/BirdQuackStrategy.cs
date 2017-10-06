using Strategies.Contracts;

namespace Strategies.Strategies
{
    internal class BirdQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "BirdQuackStrategy, Chirp, Chirp";
        }
    }
}
