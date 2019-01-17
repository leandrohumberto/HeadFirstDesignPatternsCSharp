using System;

namespace Chapter12.Ducks
{
    public class RedheadDuck : IQuackable
    {
        Observable _observable;

        public RedheadDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
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
            return "Redhead Duck";
        }
    }
}
