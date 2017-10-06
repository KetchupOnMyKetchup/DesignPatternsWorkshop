using System;

namespace Decorator
{
    /// <summary>
    /// Provides a concrete implementation of the Ferrri Spider car.
    /// </summary>
    public class FerrariSpider : Car
    {
        private double _cost = 250000;
        private string _description = "Ferrari Spider ";
        
        public override double Cost
        {
	        get 
	        { 
		         return _cost;
	        }
        }

        public override string Description
        {
            get
            {
                return _description;
            }
        }

        public override void Purchase()
        {
            Console.WriteLine("Purchasing {0} for ${1}", _description, _cost);
        }
    }
}
