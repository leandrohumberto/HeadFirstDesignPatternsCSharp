namespace Structural.States
{
    /// <summary>
    /// A "Concrete State" class
    /// </summary>
    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
