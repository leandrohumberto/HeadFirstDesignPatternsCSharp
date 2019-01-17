using GenericCommandPatternExample.Receivers;

namespace GenericCommandPatternExample.Commands
{
    /// <summary>
    /// Declares an interface/abstract class for executing the operation(s).
    /// </summary>
    abstract class Command
    {
        /// <summary>
        /// A protected field that holds the Receiver that is linked to the command, 
        /// which is usually set via a constructor.
        /// </summary>
        protected Receiver Receiver;

        public Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        public abstract void Execute();
    }
}
