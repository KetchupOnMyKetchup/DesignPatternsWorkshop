using Strategies.Contracts;

namespace Strategies.Strategies
{
    //-- New behavior
    internal class SheepQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "Duck Baas like Lamb";
        }
    }
}
