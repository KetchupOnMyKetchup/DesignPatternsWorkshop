using System.Collections;

namespace IteratorSimple
{
    // Another custom collection class
    public class Container 
    {
        // Encapsulates an Array as underlying collection
        private readonly string[] _days = 
            {"Sun", "Mon", "Tue", "Wed", "Thr", "Fri", "Sat"};

        // Container class does not provide automatic
        // implemenation for GetEnumerator.
        // Therefore, we must explicitly provide.
        // ** Here, we implement IEnumerator from BCL
        // ** It provides implementation of Iterator.
        public IEnumerator GetEnumerator()
        {
            // Example of an internal iterator.
            // Traversal algorithm implemented 
            // directly in collection. 
            // Could leverage built-in GetEnumerator in Array
            for (var i = 0; i < _days.Length; i++)
            {
                // Implements a pause, return and resume algorithm.
                // When enumerator encounters a yield returns...
                //   (1) Pauses and bookmarks current item in collection
                //   (2) Returns value of current item to caller
                //   (3) The foreach loop then calls next item
                //   (4) Processing resumes in GetEnumerator using 
                //       bookmark as starting point for next execution
                //   (5) Process continues until no more yields
                yield return _days[i];
            }
        }
    }
}