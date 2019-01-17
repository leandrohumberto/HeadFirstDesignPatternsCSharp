namespace Structural.States
{
    /// <summary>
    /// A "Concrete State" class
    /// </summary>
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}