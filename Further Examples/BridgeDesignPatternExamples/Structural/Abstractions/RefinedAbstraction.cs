namespace Structural.Abstractions
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            base.Operation();
            Implementor.Operation();
        }
    }
}
