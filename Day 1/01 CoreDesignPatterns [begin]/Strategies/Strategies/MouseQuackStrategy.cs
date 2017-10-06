using Strategies.Contracts;

namespace Strategies.Strategies
{
    internal class MouseQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "Duck Squeaks";
        }
    }
}
