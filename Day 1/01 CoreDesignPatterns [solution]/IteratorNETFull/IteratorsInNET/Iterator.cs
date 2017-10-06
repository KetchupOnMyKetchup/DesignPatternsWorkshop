using System;
using System.Collections;

namespace IteratorManualIEnumerable
{
    public class Iterator : IEnumerator, IIterator
    {
        public Person[] People { get; set; }

        // Enumerators are positioned before the first element 
        // until the first MoveNext() call. 
        int _position = -1;

        public Iterator(Person[] people)
        {
            People = people;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < People.Length);
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return People[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

}