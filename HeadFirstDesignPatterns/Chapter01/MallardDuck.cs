using System;

namespace Chapter01
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quackBehavior = new Implementations.QuackSound();
            _flyBehavior = new Implementations.FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard Duck!");
        }
    }
}
