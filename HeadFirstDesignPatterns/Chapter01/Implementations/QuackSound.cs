using System;
using Chapter01.Behaviors;

namespace Chapter01.Implementations
{
    class QuackSound : IQuackBehavior
    {
        Action IQuackBehavior.Quack
        {
            get
            {
                return delegate { Console.WriteLine("Quack"); };
            }
        }
    }
}
