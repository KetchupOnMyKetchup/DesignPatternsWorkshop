using Strategies.Contracts;

namespace Strategies.Strategies
{
    internal class DuckQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "Quck, Quack, Quack!";
        }
    }
}
