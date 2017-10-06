using System;
using FactoryMethod.Concrete;
using FactoryMethod.Contracts;

namespace FactoryMethod.Factory
{
    public class StrawberryFactory
    {
        //Factory method responsbile for returning instantiated object at runtime
        //Based upon month parameter, returns strawberry sourcer to client via an interface
        public static IDistributor SourceOrder(int month)
        {
            // Ensure that month parameter is valid
            if (month <= 0 || month > 12)
                throw new ArgumentOutOfRangeException("month", "Argument must be greater than 0 and no larger than 12");
            
            if (month > 3 && month < 8)
                // Configure contrete class and return interface reference
                return new California {Location = "California",
                                       Carriers = Carriers.JBHunt,
                                       GrossPricePerPeck = 1.27m,
                                       FdaInspectionRequired = false,};
            
            if (month > 10 || month < 2)
                // Configure contrete class and return interface reference
                return new Mexico {Location = "Mexico",
                                   Carriers = Carriers.RoadwayExpress,
                                   GrossPricePerPeck = .11m,
                                   FdaInspectionRequired = true,};

            if (month > 8 && month < 10)
                // Configure contrete class and return interface reference
                return new Washington {Location = "Washington",
                                       Carriers = Carriers.UPS, 
                                       GrossPricePerPeck =  .87m,
                                       FdaInspectionRequired = false,};

            return new NullDistrbutor {Location = "NullDistrbutor",
                                       Carriers = Carriers.None,
                                       GrossPricePerPeck = 0m,
                                       FdaInspectionRequired = false,};
        }
    }
}