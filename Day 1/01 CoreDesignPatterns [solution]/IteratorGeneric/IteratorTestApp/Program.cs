using System;

namespace IteratorManaul
{
    internal class Program
    {
        private static void Main()
        {
            // Aggregate is iterator class that encapsulates List of strings
            var aggregate = new Aggregate();

            aggregate[0] = "One";
            aggregate[1] = "Two";
            aggregate[2] = "Three";
            aggregate[3] = "Four";
            aggregate[4] = "Five";

            // Get reference to iterator class via the aggregate class
            var iterator = aggregate.GetIterator();

            // Equivalent for a ForEach iteration construct
            for (var item = iterator.FirstItem; iterator.IsDone == false; 
                item = iterator.NextItem)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}