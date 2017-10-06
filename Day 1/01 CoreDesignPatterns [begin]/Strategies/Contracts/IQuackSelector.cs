using Strategies.Strategies;

namespace Strategies.Contracts
{
    public interface IQuackSelector
    {
        IQuackStrategy SetAnimal(QuackBehaviorEnum quackBehaviorEnum);
    }
}