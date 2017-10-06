using Strategies.Contracts;

namespace Strategies.Strategies
{
    internal class CatQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "Meow!";
        }
    }
}