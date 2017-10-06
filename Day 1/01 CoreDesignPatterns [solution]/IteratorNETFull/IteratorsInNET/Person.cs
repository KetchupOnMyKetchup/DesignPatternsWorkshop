namespace IteratorManualIEnumerable
{
    public class Person
    {
        public Person(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}