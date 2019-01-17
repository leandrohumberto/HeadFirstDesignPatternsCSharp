using System;

namespace Chapter12.Ducks
{
    public class DuckCall : IQuackable
    {
        Observable _observable;

        public DuckCall()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
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
            return "Duck Call";
        }
    }
}
