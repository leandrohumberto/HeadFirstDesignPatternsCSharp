using Chapter01.Implementations;
using System;

namespace Chapter01
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new QuackSound();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}
