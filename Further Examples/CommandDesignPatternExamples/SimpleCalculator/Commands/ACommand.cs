using SimpleCalculator.Receivers;

namespace SimpleCalculator.Commands
{
    abstract class ACommand
    {
        protected IReceiver Reciever;

        public ACommand(IReceiver reciever)
        {
            Reciever = reciever;
        }

        public abstract int Execute();
    }
}
