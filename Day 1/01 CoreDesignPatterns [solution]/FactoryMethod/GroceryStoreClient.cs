using System;
using FactoryMethod.Contracts;
using FactoryMethod.Factory;

namespace FactoryMethod
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

            //Dynamically assign my favorite strawberry month
            sourcer = StrawberryFactory.SourceOrder(5);
            Console.WriteLine("I love strawberries in {0} in which we get strawberries from {1} @ $ {2} per peck",
                "May",
                sourcer.Location,
                sourcer.GrossPricePerPeck);

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

