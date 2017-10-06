using System;
using System.Globalization;

namespace Decorator
{
    /// <summary>
    /// Driver program for creating cars and decorating them with options.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create Car -- note the upcast from Ferrari to base type of Car
            Car car = new FerrariSpider(); 

            // Instantiate option class which derives from Car and pass reference of Car
            // into it -- fuses inhertiance and composition.
            car = new OptionDecoratorLeather(car); //decorate with leather option
            car = new OptionDecoratorAlloyWheels(car); //decorate with alloy wheels option
            car = new OptionDecoratorTurbo(car); //decorate with turbo option

            Console.WriteLine("\nDescription-->" + car.Description.TrimEnd(' ',','));
            Console.WriteLine("\nCost-->" + car.Cost.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("\n");

            car.Purchase();

            // Explicitly call one of the decorator class from information
            var turboEngine = car as OptionDecoratorTurbo;

            if (turboEngine != null)
            { 
                var engineSize = turboEngine.EngineSize();
            }
            Console.ReadLine();
        }
    }
}
