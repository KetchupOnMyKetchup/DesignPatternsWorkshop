using System;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            var eats = " eats ";
            Console.WriteLine(this.GetType().Name +
                              eats + h.GetType().Name);
        }
    }
}