using System;
using Chapter01.Behaviors;

namespace Chapter01.Implementations
{
    class SqueakSound : IQuackBehavior
    {
        Action IQuackBehavior.Quack
        {
            get
            {
                return delegate { Console.WriteLine("Squeak"); };
            }
        }
    }
}
