namespace Chapter11.States
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        bool TurnCrank();
        void Dispense();
    }
}
