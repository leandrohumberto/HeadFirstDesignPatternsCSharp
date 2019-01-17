namespace Chapter07.Enumerators
{
    interface IIterator<T>
    {
        bool HasNext();
        T Next();
        void Remove(T item);

    }
}
