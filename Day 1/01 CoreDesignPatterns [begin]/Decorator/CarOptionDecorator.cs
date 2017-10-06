namespace Decorator
{
    /// <summary>
    /// Provides the base type for concrete Car options that will be used to decorate concrete cars
    /// </summary>
    public abstract class CarOptionDecorator : Car
    {
        public Car Car { get; set; }
        
        protected CarOptionDecorator(Car car)
        {
            Car = car;
        }
        
        private double _cost;
        private string _description;

        public override string Description
        {
            get { return _description; }
        }

        public override double Cost
        {
            get { return _cost; }
        }

        public override void Purchase()
        {
        }

        public virtual bool InStock()
        {
            return false;
        }
    }
}