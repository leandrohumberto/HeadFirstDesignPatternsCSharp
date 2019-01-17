using System;

namespace Chapter12
{
    public class Quackologist : IObserver<IQuackable>
    {
        public void OnCompleted()
        {
            
        }

        public void OnError(Exception error)
        {
            throw error;
        }

        public void OnNext(IQuackable value)
        {
            Console.WriteLine("Quackologist: " + value + " just quacked.");
        }
    }
}
