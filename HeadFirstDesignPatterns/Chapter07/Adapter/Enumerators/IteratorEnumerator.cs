namespace Chapter07.Enumerators
{
    class IteratorEnumerator<T> : IEnumeration<T>
    {
        private IIterator<T> _iterator;

        public bool HasMoreElements()
        {
            return _iterator.HasNext();
        }

        public T NextElement()
        {
            return _iterator.Next();
        }
    }
}
