namespace IteratorManaul
{
    internal interface IAggregate
    {
        // Implements IIterator interface with navigation operations
        IIterator GetIterator();
        
        // Indexer
        string this[int itemIndex] { set; get; }
        
        int Count { get; }
    }
}