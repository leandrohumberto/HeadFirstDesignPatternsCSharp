using GenericCommandPatternExample.Receivers;

namespace GenericCommandPatternExample.Commands
{
    /// <summary>
    /// ConcreteCommand - Defines a binding/link between a Receiver object and Receiver's action.    
    /// Extends the Command interface, Implements Execute method by invoking the corresponding operation(s) on Receiver
    /// </summary>
    class ConcreteCommand : Command
    {
        /// <summary>
        /// Constructor takes the linked Receiver object, the same receiver object (called linked receiver) 
        /// might be used by other concrete commands which will be passed from client.
        /// </summary>
        /// <param name="receiver"></param>
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            Receiver.Action();
        }
    }
}
