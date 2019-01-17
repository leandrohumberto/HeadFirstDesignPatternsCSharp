using Structural.Abstractions;
using Structural.Implementors;
using System;

namespace Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Bridge Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.SetImplementor(new ConcreteImplementorA());
            ab.Operation();

            // Change implemention and call
            ab.SetImplementor(new ConcreteImplementorB());
            ab.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}
