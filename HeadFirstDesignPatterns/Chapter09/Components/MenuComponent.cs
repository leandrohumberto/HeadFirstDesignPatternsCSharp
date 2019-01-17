using System;
using System.Collections;

namespace Chapter09.Components
{
    public abstract class MenuComponent : IEnumerable
    {
        public virtual string Name { get { throw new InvalidOperationException(); } }

        public virtual string Description { get { throw new InvalidOperationException(); } }

        public virtual double Price { get { throw new InvalidOperationException(); } }

        public virtual bool IsVegetarian { get { throw new InvalidOperationException(); } }

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual MenuComponent GetChild(int index)
        {
            throw new InvalidOperationException();
        }

        public abstract override string ToString();

        public abstract IEnumerator GetEnumerator();
    }
}
