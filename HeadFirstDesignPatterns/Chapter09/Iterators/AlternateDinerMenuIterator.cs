using Chapter09.Components;
using System;
using System.Collections;

namespace Chapter09.Iterators
{
    public class AlternateDinerMenuIterator : IEnumerator
    {
        private readonly MenuItem[] _menuItems;
        private int _position;
        private bool _started;

        public AlternateDinerMenuIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
            Reset();
        }

        public object Current
        {
            get
            {
                if (!_started)
                {
                    throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
                }

                return _menuItems[_position];
            }
        }

        public bool MoveNext()
        {
            var moved = false;

            if (_position + 2 < _menuItems.Length && _menuItems[_position + 2] != null)
            {
                _position += 2;
                moved = true;
            }

            _started = true;
            return moved;
        }

        public void Reset()
        {
            _position = (int)DateTime.Now.DayOfWeek % 2;
        }
    }
}
