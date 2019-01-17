namespace Chapter07.Enumerators
{
    class EnumeratorIterator<T> : IIterator<T>
    {
        IEnumeration<T> _enum;

        public bool HasNext()
        {
            return _enum.HasMoreElements();
        }

        public T Next()
        {
            return _enum.NextElement();
        }

        public void Remove(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}
