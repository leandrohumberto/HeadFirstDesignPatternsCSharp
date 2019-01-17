using System;
using Chapter01.Behaviors;

namespace Chapter01.Implementations
{
    class FlyWithWings : IFlyBehavior
    {
        Action IFlyBehavior.Fly
        {
            get
            {
                return delegate { Console.WriteLine("I'm flying!!"); };
            }
        }
    }
}
