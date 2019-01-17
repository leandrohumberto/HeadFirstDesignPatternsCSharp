using Chapter01.Behaviors;
using System;

namespace Chapter01.Implementations
{
    class FlyRocketPower : IFlyBehavior
    {
        public Action Fly
        {
            get
            {
                return delegate { Console.WriteLine("I'm flying with a rocket!"); };
            }
        }
    }
}
