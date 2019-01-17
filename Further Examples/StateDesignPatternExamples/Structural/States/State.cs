namespace Structural.States
{
    /// <summary>
    /// The "State" abstract class
    /// </summary>
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
