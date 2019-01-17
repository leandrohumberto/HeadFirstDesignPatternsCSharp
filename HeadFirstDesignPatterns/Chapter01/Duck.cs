using Chapter01.Behaviors;
using System;

namespace Chapter01
{
    abstract class Duck
    {
        protected IQuackBehavior _quackBehavior;
        
        public IQuackBehavior QuackBehavior { set { _quackBehavior = value; } }

        protected IFlyBehavior _flyBehavior;

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior ?? throw new ArgumentNullException();
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior ?? throw new ArgumentNullException();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();
    }
}
