using System;

namespace Chapter11.States
{
    public class SoldOutState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can’t eject, you haven’t inserted a quarter yet.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can’t insert a quarter, the machine is sold out.");
        }
        
        public bool TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs.");
            return false;
        }

        public override string ToString()
        {
            return "sold out";
        }
    }
}
                                                                            