using System;
using FactoryMethod.Contracts;
using FactoryMethod.Factory;
using FactoryMethod.Concrete;

namespace FactoryClient
{
    internal class GroceryStoreClient
    {
        private static void Main()
        {
            var program = new GroceryStoreClient();
            program.OrderStrawberries();
        }

        private void OrderStrawberries()
        {
            //Holds reference to strawberry sourcer
            IDistributor sourcer;


            // Note that cannot directly instantiate concrete class as they are scoped as internal
            //sourcer = new California();

            //Dynamically assign my favorite strawberry month
            sourcer = StrawberryFactory.SourceOrder(5);
            Console.WriteLine("I love strawberries in {0} in which we get strawberries from {1} @ $ {2} per peck",
                "May",
                sourcer.Location,
                sourcer.GrossPricePerPeck);


            // Note that property is readonly in interface, but read/write in concrete object
            //sourcer.FdaInspectionRequired = true;

           
            //Dynamically assign my favorite strawberry month
            sourcer = StrawberryFactory.SourceOrder(12);
            Console.WriteLine("I hate strawberries in {0} in which we get strawberries from {1} @ $ {2} per peck",
                "December",
                sourcer.Location,
                sourcer.GrossPricePerPeck);

            Console.ReadLine();
        }
    }
}
