using System;
using System.Linq;
using System.Collections;
using Chapter09.Components;

namespace Chapter09.Iterators
{
    public class DinerMenu : IEnumerable
    {
        private static readonly int MAX_ITENS = 6;
        private int _numberOfItems = 0;
        MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITENS];

            AddItem("Vegetarian BLT", "(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
            
            // a couple of other Diner Menu items added here
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            if (_numberOfItems >= MAX_ITENS)
            {
                throw new InvalidOperationException("The menu reached its maximum number of items.");
            }

            MenuItem item = new MenuItem(name, description, vegetarian, price);
            _menuItems[_numberOfItems] = item;
            _numberOfItems++;
        }

        public IEnumerator GetEnumerator() => //_menuItems.Where(p => p != null).Select(p => p).GetEnumerator();
            new Iterators.AlternateDinerMenuIterator(_menuItems);

        // other menu methods here
    }
}
