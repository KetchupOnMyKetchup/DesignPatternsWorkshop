using System;

namespace Decorator
{
    internal class OptionDecoratorSound : CarOptionDecorator
    {
        private double _cost = 1000;
        private string _description = "Bose Sound System, ";

        public OptionDecoratorSound(Car car) : base(car) {}

        public override double Cost
        {
            get { return Car.Cost + _cost; }
        }

        public override string Description
        {
            get { return Car.Description + _description; }
        }

        public override void Purchase()
        {
            Console.WriteLine("Purchasing {0} for ${1}", _description, _cost);
            Car.Purchase();
        }
    }
}