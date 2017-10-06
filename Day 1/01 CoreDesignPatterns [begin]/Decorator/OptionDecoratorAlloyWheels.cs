using System;

namespace Decorator
{
    /// <summary>
    /// Provides a concrete implementation of the Alloy Wheels Car option.
    /// </summary>
    public class OptionDecoratorAlloyWheels : CarOptionDecorator
    {
        private double _cost = 4564.42;
        private string _description = "Alloy Wheels, ";

        public OptionDecoratorAlloyWheels(Car car) : base(car) {}

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

        public override bool InStock()
        {
            return true;
        }
    }
}
