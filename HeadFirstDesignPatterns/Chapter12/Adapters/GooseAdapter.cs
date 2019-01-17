using System;
using Chapter12.Geese;
using Chapter12.Ducks;

namespace Chapter12.Adapters
{
    public class GooseAdapter : IQuackable
    {
        Goose _goose;
        Observable _observable;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _observable = new Observable(this);
        }

        public void NotifySubscribers()
        {
            _observable.NotifySubscribers();
        }

        public void Quack()
        {
            _goose.Honk();
            NotifySubscribers();
        }

        public IDisposable Subscribe(IObserver<IQuackable> observer)
        {
            return _observable.Subscribe(observer);
        }

        public override string ToString()
        {
            return "Goose pretending to be a duck";
        }
    }
}
