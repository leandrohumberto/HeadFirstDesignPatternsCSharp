using SimpleCalculator.Receivers;

namespace SimpleCalculator.Commands
{
    class MultiplyCommand : ACommand
    {
        public MultiplyCommand(IReceiver reciever) : base(reciever)
        {
        }

        public override int Execute()
        {
            Reciever.SetAction(Action.Multiply);
            return Reciever.GetResult();
        }
    }
}
