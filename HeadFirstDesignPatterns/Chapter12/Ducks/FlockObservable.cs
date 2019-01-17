using System;
using System.Collections.Generic;

namespace Chapter12.Ducks
{
    public class FlockObservable : IQuackObservable
    {
        private List<IObserver<IQuackable>> _observers = new List<IObserver<IQuackable>>();
        private List<IQuackable> _quackers;

        public FlockObservable(IEnumerable<IQuackable> quackers)
        {
            _quackers = new List<IQuackable>(quackers);
        }

        public void AddQuacker(IQuackable quacker)
        {
            _quackers.Add(quacker);

            foreach (var observer in _observers)
            {
                quacker.Subscribe(observer);
            }
        }

        public void NotifySubscribers()
        {
        }

        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            _observers.Add(observer);

            foreach (IQuackable quackers in _quackers)
            {
                quackers.Subscribe(observer);
            }

            return null;
        }
    }
}
