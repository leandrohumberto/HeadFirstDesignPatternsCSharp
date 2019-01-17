using Structural.States;
using System;

namespace Structural
{
    // https://www.codeproject.com/Articles/489136/UnderstandingplusandplusImplementingplusStateplusP

    /// <summary>
    /// MainApp startup class for Structural
    /// State Design Pattern. http://www.dofactory.com/net/state-design-pattern
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            // Setup context with a state
            Context c = new Context(new ConcreteStateA());

            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
