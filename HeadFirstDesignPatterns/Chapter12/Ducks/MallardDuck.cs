using System;

namespace Chapter12.Ducks
{
    public class MallardDuck : IQuackable
    {
        Observable _observable;

        public MallardDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifySubscribers();
        }

        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            return _observable.Subscribe(observer);
        }

        public void NotifySubscribers()
        {
            _observable.NotifySubscribers();
        }

        public override string ToString()
        {
            return "Mallard Duck";
        }
    }
}
