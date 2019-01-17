using System;

namespace AccountManagement.States
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Red indicates that account is overdrawn 
    /// </remarks>
    /// </summary>
    public class RedState : State
    {
        private double _serviceFee;

        public RedState(State state)
        {
            Balance = state.Balance;
            Account = state.Account;
            Initialize();
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            // No interest is paid
        }

        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }

        private void StateChangeCheck()
        {
            if (Balance > UpperLimit)
            {
                Account.State = new SilverState(this);
            }
        }

        private void Initialize()
        {
            Interest = 0;
            LowerLimit = -100;
            UpperLimit = 0;
            _serviceFee = 15;
        }
    }
}
