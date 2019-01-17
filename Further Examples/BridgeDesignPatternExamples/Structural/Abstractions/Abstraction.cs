using Structural.Implementors;

namespace Structural.Abstractions
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public class Abstraction
    {
        protected Implementor Implementor { get; private set; }

        // Property
        public void SetImplementor(Implementor implementor) => Implementor = implementor;

        public virtual void Operation()
        {
            Implementor.Operation();
        }
    }
}
