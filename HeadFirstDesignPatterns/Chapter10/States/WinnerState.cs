using System;

namespace Chapter11.States
{
    public class WinnerState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("YOU’RE A WINNER! You get two gumballs for your quarter");
            _gumballMachine.ReleaseBall();

            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
            else
            {
                _gumballMachine.ReleaseBall();

                if (_gumballMachine.Count > 0)
                {
                    _gumballMachine.SetState(_gumballMachine.NoQuarterState);
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _gumballMachine.SetState(_gumballMachine.SoldOutState);
                }
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball.");
        }

        public bool TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
            return false;
        }

        public override string ToString()
        {
            return "dispensing a gumball";
        }
    }
}
