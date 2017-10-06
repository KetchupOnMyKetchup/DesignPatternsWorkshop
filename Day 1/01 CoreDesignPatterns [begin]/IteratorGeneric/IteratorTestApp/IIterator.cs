namespace IteratorManaul
{
    internal interface IIterator
    {
        string FirstItem { get; }
        string NextItem { get; }
        string CurrentItem { get; }
        bool IsDone { get; }
    }
}