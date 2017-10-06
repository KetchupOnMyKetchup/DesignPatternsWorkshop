namespace IteratorManualIEnumerable
{
    public interface IIterator
    {
        bool MoveNext();
        void Reset();
        Person Current { get; }
    }
}