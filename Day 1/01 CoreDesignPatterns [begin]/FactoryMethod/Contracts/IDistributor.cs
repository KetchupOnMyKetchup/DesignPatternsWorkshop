using System;

namespace FactoryMethod.Contracts
{
    public interface IDistributor
    {
        // Note properties are read-only
        string Location { get; }
        Decimal GrossPricePerPeck { get; }
        Decimal NetPricePerPeck(int deliveryMonth, int deliveryCoordinates, int discountCode);
        bool FdaInspectionRequired { get; }
        Carriers Carriers { get; }
    }
}