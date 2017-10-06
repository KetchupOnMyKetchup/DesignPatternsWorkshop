using Strategies.Contracts;
using Strategies.Strategies;

namespace Strategies.Selector
{
    // The Strategy Context class
    public class QuackSelector : IQuackSelector
    {
        private IQuackStrategy QuackStrategySound { get; set; }

        public IQuackStrategy SetAnimal(QuackBehaviorEnum quackBehaviorEnum)
        {
            switch (quackBehaviorEnum)
            {
                case QuackBehaviorEnum.Bird:
                    QuackStrategySound = new BirdQuackStrategy();
                    break;
                
                case QuackBehaviorEnum.Duck:
                    QuackStrategySound = new DuckQuackStrategy();
                    break;

                case QuackBehaviorEnum.Cat:
                    QuackStrategySound = new CatQuackStrategy();
                    break;

                case QuackBehaviorEnum.Dog:
                    QuackStrategySound = new DogQuackStrategy();
                    break;

                case QuackBehaviorEnum.Lion:
                    QuackStrategySound = new LionQuackStrategy();
                    break;

                case QuackBehaviorEnum.Mouse:
                    QuackStrategySound = new MouseQuackStrategy();
                    break;

                // Add new quackStrategy
                //case QuackBehaviorEnum.Sheep:
                //    QuackStrategySound = new SheepQuackStrategy();
                //    break;

                default:
                    QuackStrategySound = new DuckQuackStrategy();
                    break;
            }

            return QuackStrategySound;
        }
    }
}