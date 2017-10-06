using Strategies;
using Strategies.Contracts;
using Strategies.Selector;

namespace Strategy
{
    public class Duck
    {
        // Property to which assign quackStrategy behavior
        public IQuackStrategy QuackSound { get; set; }

        // Optional parameter usage
        public Duck(IQuackStrategy quackStrategy = null)
        {
            // Duck depends on IQuackSelecctor which is a factory
            // Determines which (Strategy) animal to inject
            // Note how quack selection decoupled from Duck class
            // Change quackStrategy types without modifying Duck.
            IQuackSelector quackSelector = new QuackSelector();

            // If parameter not passed, set default quackStrategy to Duck 
            // Note usage of null-coalescing operator
            QuackSound = quackStrategy ?? quackSelector.SetAnimal(QuackBehaviorEnum.Duck);
        }

        public string Quack()
        {
            return QuackSound.Quack();
        }
    }
}