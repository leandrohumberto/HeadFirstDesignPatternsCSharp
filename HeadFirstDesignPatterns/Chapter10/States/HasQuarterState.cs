using System;

namespace Chapter11.States
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;
        private readonly Random _randomWinner = new Random();

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned.");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter.");
        }

        public bool TurnCrank()
        {
            Console.WriteLine("You turned...");

            if (_randomWinner.Next(10) == 1 && _gumballMachine.Count > 1)
            {
                _gumballMachine.SetState(_gumballMachine.WinnerState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldState);
            }

            return true;
        }

        public override string ToString()
        {
            return "waiting for turn of crank";
        }
    }
}
