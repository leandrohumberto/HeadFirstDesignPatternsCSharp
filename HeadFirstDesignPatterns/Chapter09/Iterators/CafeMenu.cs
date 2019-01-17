using Chapter09.Components;
using System.Collections;

namespace Chapter09.Iterators
{
    public class CafeMenu : IEnumerable
    {
        private Hashtable _menuItems = new Hashtable();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99);
            AddItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69);
            AddItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem item = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(item.Name, item);
        }

        public IEnumerator GetEnumerator() => _menuItems.Values.GetEnumerator();
    }
}
