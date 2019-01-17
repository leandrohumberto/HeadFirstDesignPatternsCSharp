using GenericCommandPatternExample.Commands;
using GenericCommandPatternExample.Invokers;
using GenericCommandPatternExample.Receivers;
using System;

namespace GenericCommandPatternExample
{
    /// <summary>
    /// Creates a ConcreteCommand object and sets its receiver. 
    /// Instantiates the command object and provides the information required to call the method at a later time. 
    /// Source: https://code.msdn.microsoft.com/windowsapps/Design-Patterns-Command-1962d567
    /// </summary>
    class Client
    {
        static void Main(string[] args)
        {
            // Create receiver, command, and invoker      
            var ReceiverObject = new Receiver();

            //Creates a ConcreteCommand object and sets its receiver     
            //Instantiates the command object and provides the information required to call the method at a later time.      
            var CommandObject = new ConcreteCommand(ReceiverObject);

            // Invoker - Asks the command to carry out the request.     
            // Decides when the method should be called.     
            var InvokerObject = new Invoker();
            InvokerObject.SetCommand(CommandObject);
            InvokerObject.ExecuteCommand();

            // Wait for user      
            Console.ReadKey();
        }
    }
}
