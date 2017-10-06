using FactoryMethod.Contracts;

namespace FactoryMethod.Concrete
{
    internal class Washington : IDistributor
    {
        public Carriers Carriers { get; set; }
        public decimal GrossPricePerPeck { get; set; }
        public string Location { get; set; }
        public bool FdaInspectionRequired { get; set; }

        public Washington() {}

        public decimal NetPricePerPeck(int deliveryMonth, int deliveryCoordinate, int discountCode)
        {
            // Complex algorithm to determine price for specific client 
            return .98m;
        }
    }
}