namespace IteratorManaul
{
    internal class Iterator : IIterator
    {
        // Holds reference to the aggregate interface, not the concrete object
        private readonly IAggregate _aggregate;
        private int _currentIndex;

        public Iterator(IAggregate aggregate)
        {
            // Note that we are talking to the interface,
            // not the concrete object here. We don't know 
            // what collection that we are iterating.
            _aggregate = aggregate;
        }

        public string FirstItem
        {
            get
            {
                _currentIndex = 0;
                return _aggregate[_currentIndex];
            }
        }

        public string NextItem
        {
            get
            {
                _currentIndex += 1;

                return IsDone == false ? _aggregate[_currentIndex] : string.Empty;
            }
        }

        public string CurrentItem
        {
            get { return _aggregate[_currentIndex]; }
        }

        public bool IsDone
        {
            get
            {
                return _currentIndex >= _aggregate.Count;
            }
        }
    }
}