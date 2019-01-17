using Chapter12.Ducks;

namespace Chapter12
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}
