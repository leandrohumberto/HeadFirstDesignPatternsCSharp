using Chapter12.Ducks;
using System;

namespace Chapter12.Decorators
{
    public class QuackCounter : IQuackable
    {
        private Observable _observable;
        private IQuackable _duck;

        public static int Count { get; private set; } = 0;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
            _observable = new Observable(_duck);
        }

        public void Quack()
        {
            _duck.Quack();
            Count++;
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
            return _duck.ToString();
        }
    }
}
