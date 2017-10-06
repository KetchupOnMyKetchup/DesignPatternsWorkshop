using System.Collections;

namespace IteratorManualIEnumerable
{
    /// <summary>
    /// Container encapsulate Array which implements IEnumerable
    /// </summary>
    public class Container : IContainer  
    {
        // Underlying container is Array
        private readonly Person[] _people;
        public Container(Person[] pArray)
        {
            _people = pArray;
        }

        // IEnumerable requires implementation of 1 member:
        // GetEnumerator. Returns interface to stand-alone
        // iterator class that knows how to traverse collection.
        // **** Note here that we do not leverage IEnumerator from BCL
        // **** which provides built-in implementation of an Iterator
        public IIterator GetEnumerator()
        {
            // Container class instantiates concrete iterator,
            // returning interface reference to caller
            return new Iterator(_people);
        }
    }

}