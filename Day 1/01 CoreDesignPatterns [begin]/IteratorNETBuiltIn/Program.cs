using System;
using System.Collections.Generic;

namespace IteratorBuiltIn
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var program = new Program();
            program.IterateCollection();
            Console.WriteLine("Press Enter to Complete");
            Console.ReadLine();
        }

        private void IterateCollection()
        {
            // Underlying collection is a list
            var weekdays = 
                new List<string> {"Monday", "Tuesday", "Wednesday"};

            // ForEach leverages built 
            // enumeration from List collection
            foreach (var weekday in weekdays)
            {
                Console.WriteLine(weekday);
            }
        }
    }
}