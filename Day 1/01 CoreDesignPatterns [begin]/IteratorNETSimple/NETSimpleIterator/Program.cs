namespace IteratorSimple
{
    internal class IteratorNetSimple
    {
        private static void Main()
        {
            // Create an instance of Aggregate (collection class)
            var week = new Container();

            // Iterate collection with foreach 
            // Foreach construct automatically calls 
            // GetEnumerator on underlying collection.
            foreach (string day in week)
            {
                System.Console.Write(day + " ");

                if (day == "Tue")
                    break;
            }
        }
    }
}