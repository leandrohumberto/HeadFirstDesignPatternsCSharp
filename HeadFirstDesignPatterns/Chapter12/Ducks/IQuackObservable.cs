using System;

namespace Chapter12.Ducks
{
    public interface IQuackObservable : IObservable<IQuackable>
    {
        void NotifySubscribers();
    }
}
