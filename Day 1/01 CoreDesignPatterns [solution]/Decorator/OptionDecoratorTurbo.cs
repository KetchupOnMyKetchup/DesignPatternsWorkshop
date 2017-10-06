using System;

namespace Decorator
{
    /// <summary>
    /// Provides a concrete implementation of the Turbo Car option.
    /// </summary>
    public class OptionDecoratorTurbo : CarOptionDecorator
    {
        private double _cost = 7000.24;
        private string _description = "Turbo, ";

        public OptionDecoratorTurbo(Car car) : base(car){}

        public override double Cost
        {
            get
            {
                return Car.Cost + _cost;
            }
        }

        public override string Description
        {
            get
            {
                return Car.Description + _description;
            }
        }

        public override void Purchase()
        {
            Console.WriteLine("Purchasing {0} for ${1}", _description, _cost);
            Car.Purchase();
        }

        public string EngineSize()
        {
            return "660 Cubic ML";
        }
    }
}
