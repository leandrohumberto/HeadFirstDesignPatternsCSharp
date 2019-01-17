using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter12.Ducks
{
    public class Flock : IQuackable, IEnumerable<IQuackable>
    {
        private List<IQuackable> _quackers = new List<IQuackable>();
        private FlockObservable _observable;

        public Flock()
        {
            _observable = new FlockObservable(this);
        }

        public void Add(IQuackable quackable)
        {
            _quackers.Add(quackable);
            _observable.AddQuacker(quackable);
        }

        public IEnumerator<IQuackable> GetEnumerator()
        {
            return _quackers.GetEnumerator();
        }

        public void Quack()
        {
            foreach (var quacker in _quackers)
            {
                quacker.Quack();
            }

            NotifySubscribers();
        }

        public void NotifySubscribers()
        {
        }

        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            return _observable.Subscribe(observer);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
