using System.Collections;
using System.Globalization;
using System.Linq;

namespace Chapter09.Components
{
    public class MenuItem : MenuComponent
    {
        public override string Name { get; }

        public override string Description { get; }

        public override bool IsVegetarian { get; }

        public override double Price { get; }

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = vegetarian;
            Price = price;
        }

        public override string ToString()
        {
            var str = " " + Name;

            if (IsVegetarian)
            {
                str += "(v)";
            }

            str += ", " + Price.ToString(CultureInfo.CurrentUICulture);
            str += "\n    -- " + Description;

            return str;
        }

        public override IEnumerator GetEnumerator() => Enumerable.Empty<IEnumerator>().GetEnumerator();
    }
}
