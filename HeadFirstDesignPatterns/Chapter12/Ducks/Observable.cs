using System;
using System.Collections.Generic;

namespace Chapter12.Ducks
{
    public class Observable : IQuackObservable
    {
        private List<IObserver<IQuackable>> _observers = new List<IObserver<IQuackable>>();
        private IQuackable _duck;

        public Observable(IQuackable duck)
        {
            _duck = duck;
        }

        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            _observers.Add(observer);
            return null;
        }

        public void NotifySubscribers()
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(_duck);
            }
        }
    }
}
