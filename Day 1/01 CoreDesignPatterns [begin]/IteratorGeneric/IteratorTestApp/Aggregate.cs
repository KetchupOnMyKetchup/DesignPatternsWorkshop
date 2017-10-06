using System.Collections.Generic;

namespace IteratorManaul
{
    // Custom collection of some sort through which we will need to iterate
    internal class Aggregate : IAggregate
    {
        // Encapsulates List of strings
        private readonly List<string> _aggregateValues;

        public Aggregate()
        {
            // Instantiate List collection as underlying container
            _aggregateValues = new List<string>();
        }

        // Returns IIterator reference with navigation operations
        public IIterator GetIterator()
        {
            // Pass in interface reference to collection (Aggregate Class) to Iterator.
            // Iterator will have no idea of collection (concrete class) -- just the interface. 
            return new Iterator(this);
        }

        public string this[int itemIndex]
        {
            get
            {
                if (itemIndex < _aggregateValues.Count)
                {
                    return _aggregateValues[itemIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
            set { _aggregateValues.Add(value); }
        }

        public int Count
        {
            get { return _aggregateValues.Count; }
        }
    }
}