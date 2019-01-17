using Chapter11.States;
using System.Text;

namespace Chapter11
{
    public class GumballMachine
    {
        internal IState SoldOutState { get; }

        internal IState NoQuarterState { get; }

        internal IState HasQuarterState { get; }

        internal IState SoldState { get; }

        internal IState WinnerState { get; }

        internal int Count { get; private set; }

        private IState _state;

        public GumballMachine(int numberGumballs)
        {
            Count = numberGumballs;
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);
            _state = (Count > 0) ? NoQuarterState : SoldOutState;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            if (_state.TurnCrank())
            {
                _state.Dispense();
            }
        }

        internal void SetState(IState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            System.Console.WriteLine("A gumball comes rolling out the slot...");

            if (Count > 0)
            {
                Count--;
            }
        }

        internal void Refill(int count)
        {
            Count = count;
            _state = NoQuarterState;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nJava-enabled Standing Gumball Model #2004");
            result.Append("\nInventory: " + Count + " gumball");

            if (Count != 1)
            {
                result.Append("s");
            }

            result.Append("\n");
            result.Append("Machine is " + _state + "\n");
            return result.ToString();
        }
    }
}
