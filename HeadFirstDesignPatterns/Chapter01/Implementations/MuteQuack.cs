using System;
using Chapter01.Behaviors;

namespace Chapter01.Implementations
{
    class MuteQuack : IQuackBehavior
    {
        Action IQuackBehavior.Quack
        {
            get
            {
                return delegate { Console.WriteLine("<< Silence >>"); };
            }
        }
    }
}
