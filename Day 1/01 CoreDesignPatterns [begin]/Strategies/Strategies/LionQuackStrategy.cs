using Strategies.Contracts;

namespace Strategies.Strategies
{
    //-- Variable Quack Behavior
    internal class LionQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "Quack Loudly";
        }
    }
}