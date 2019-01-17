using SimpleCalculator.Receivers;

namespace SimpleCalculator.Commands
{
    class AddCommand : ACommand
    {
        public AddCommand(IReceiver reciever) : base(reciever)
        {
        }

        public override int Execute()
        {
            Reciever.SetAction(Action.Add);
            return Reciever.GetResult();
        }
    }
}
