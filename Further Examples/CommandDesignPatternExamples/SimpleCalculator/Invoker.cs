using SimpleCalculator.Commands;
using SimpleCalculator.Receivers;
using System;

namespace SimpleCalculator
{
    class Invoker
    {
        static void Main(string[] args)
        {
            var receiver = new Calculator(345, 9945);
            var addCommand = new AddCommand(receiver);
            var subtractCommand = new SubtractCommand(receiver);
            var multiplyCommand = new MultiplyCommand(receiver);

            Console.WriteLine($"Add command result: {addCommand.Execute()}");
            Console.WriteLine($"Subtract command result: {subtractCommand.Execute()}");
            Console.WriteLine($"Multiply command result: {multiplyCommand.Execute()}");
            Console.ReadKey();
        }
    }
}
