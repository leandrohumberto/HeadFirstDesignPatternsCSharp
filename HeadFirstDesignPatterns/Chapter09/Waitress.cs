using Chapter09.Components;
using System;
using System.Collections;

namespace Chapter09
{
    public class Waitress
    {
        MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            Console.WriteLine(_allMenus.ToString());
        }
        public void PrintVegetarianMenu()
        {
            IEnumerator enumerator = _allMenus.GetEnumerator();
            Console.WriteLine("\nVEGETARIAN MENU\n----");

            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;

                try
                {
                    if (menuComponent.IsVegetarian)
                    {
                        Console.WriteLine(menuComponent.ToString());
                    }
                }
                catch (InvalidOperationException)
                {

                }
            }
        }

        // other methods here
    }
}
