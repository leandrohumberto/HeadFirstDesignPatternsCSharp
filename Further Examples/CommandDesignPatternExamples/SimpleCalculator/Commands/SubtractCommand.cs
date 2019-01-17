using SimpleCalculator.Receivers;

namespace SimpleCalculator.Commands
{
    class SubtractCommand : ACommand
    {
        public SubtractCommand(IReceiver reciever) : base(reciever)
        {
        }

        public override int Execute()
        {
            Reciever.SetAction(Action.Subtract);
            return Reciever.GetResult();
        }
    }
}
