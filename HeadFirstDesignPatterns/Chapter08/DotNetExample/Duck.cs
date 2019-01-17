using System;

namespace Chapter08.DotNetExample
{
    class Duck : IComparable<Duck>
    {
        private string _name;
        private int _weight;

        public Duck(string name, int weight)
        {
            _name = name;
            _weight = weight;
        }

        public override string ToString()
        {
            return $"{_name} weights {_weight}";
        }

        public int CompareTo(Duck other)
        {
            return _weight - other._weight;
        }
    }
}
