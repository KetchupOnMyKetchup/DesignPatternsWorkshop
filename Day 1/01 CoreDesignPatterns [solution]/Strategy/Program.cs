using System;
using Strategies;
using Strategies.Contracts;
using Strategies.Selector;

namespace Strategy
{
    public class Program
    {
        private static DuckGame _duckGame;

        private static void Main()
        {
            // First, instantiate Duck
            var _duckGame = new DuckGame();

            _duckGame.PlayDuck();

            Console.WriteLine("Game Over - Press Any Key To End");
            Console.ReadLine();
        }


        public class DuckGame
        {
            // Instantiate Duck Class -- Pass no parameter
            private readonly Duck _duck = new Duck();
            private IQuackSelector _quackSelector = new QuackSelector();

            public void PlayDuck()
            {
                // Make Duck quack with default quack (Strategy) behavior
                MakeDuckQuack();

                InjectNewQuackBehaviorAtRuntime();

                // Make Duck quack again now with default quack (Strategy) behavior
                MakeDuckQuack();

                // Add new animal (Strategy) behavior
                AddNewAnimal();

                // Make Duck quack again now with default quack (Strategy) behavior
                MakeDuckQuack();
            }

            private void MakeDuckQuack()
            {
                // Accept default constructor values - which will default to loud quackStrategy
                _duck.Quack();
            }

            private void InjectNewQuackBehaviorAtRuntime()
            {
                // Dynamically set quack (Strategy) behavior
                _duck.QuackSound = _quackSelector.SetAnimal(QuackBehaviorEnum.Lion);
            }

            private void AddNewAnimal()
            {
                // Need to update strategy infrastructure, but not Duck
                // (1) Add new quackStrategy class (Sheep)
                // (2) Add new QuackBehavior Enum -- could add long before implementation 
                // (3) Modify QuackSelector - add Sheep to conditional
                // No modification to Duck

                // Add squeak enum, class and update to context object
                ////_duck.QuackSound = _quackSelector.SetAnimal(QuackBehaviorEnum.Sheep);
            }
        }
    }
}