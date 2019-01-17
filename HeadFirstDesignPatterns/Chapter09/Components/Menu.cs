using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Chapter09.Components
{
    public class Menu : MenuComponent
    {
        private readonly List<MenuComponent> _menuComponents = new List<MenuComponent>();

        public override string Name { get; }

        public override string Description { get; }

        public Menu(string name , string description)
        {
            Name = name;
            Description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int index)
        {
            return _menuComponents[index];
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.Append("\n" + Name);
            str.Append(", " + Description + "\n");
            str.Append("---------------------\n");
            str.AppendLine();

            foreach (var item in _menuComponents)
            {
                str.Append(item.ToString() + "\n");
            }

            return str.ToString();
        }

        public override IEnumerator GetEnumerator()
        {
            // Ugly, unefficient previous code

            // var list = new List<MenuComponent>();
            // ComponentsToList(list);
            // list.Remove(this);
            // return list.GetEnumerator();

            // Clever, elegant algorithm 
            // Source: https://stackoverflow.com/questions/39085721/how-to-implement-the-ienumeratort-interface-for-the-composite-pattern
            var components = new Stack<MenuComponent>(new[] { this });

            while (components.Count > 0)
            {
                MenuComponent component = components.Pop();
                yield return component;

                if (component is Menu)
                {
                    Menu menu = component as Menu;

                    for (var i = menu._menuComponents.Count - 1; i >= 0; i--)
                    {
                        var item = menu._menuComponents[i];

                        if (item is MenuComponent)
                        {
                            components.Push(item as MenuComponent);
                        }
                    }
                }
            }
        }

        //private void ComponentsToList(IList<MenuComponent> list)
        //{
        //    list.Add(this);

        //    foreach (var item in _menuComponents)
        //    {
        //        if (item is Menu)
        //        {
        //            (item as Menu).ComponentsToList(list);
        //        }
        //        else
        //        {
        //            list.Add(item);
        //        }
        //    }
        //}
    }
}
