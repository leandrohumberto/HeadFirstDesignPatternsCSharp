﻿using System;

namespace Chapter11.States
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter.");
            _gumballMachine.SetState(_gumballMachine.HasQuarterState);
        }

        public bool TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter.");
            return false;
        }

        public override string ToString()
        {
            return "waiting for quarter";
        }
    }
}
