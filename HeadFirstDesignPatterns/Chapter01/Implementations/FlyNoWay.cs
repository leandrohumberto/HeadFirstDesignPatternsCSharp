using System;

namespace Chapter01.Implementations
{
    class FlyNoWay : Behaviors.IFlyBehavior
    {
        public Action Fly
        {
            get
            {
                return delegate { Console.WriteLine("I can't fly"); };
            }
        }
    }
}
