using System;

namespace Chapter12.Ducks
{
    public class RubberDuck : IQuackable
    {
        Observable _observable;

        public RubberDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Squeak");
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
            return "Rubber Duck";
        }
    }
}
