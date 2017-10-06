using System;

namespace IteratorManualIEnumerable
{
    internal class Program
    {
        private static void Main()
        {
            var peopleArray = new[]
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon")
            };

            IContainer people = new Container(peopleArray);

            foreach (var p in people)
                Console.WriteLine(p.FirstName + " " + p.LastName);
        }
    }
}