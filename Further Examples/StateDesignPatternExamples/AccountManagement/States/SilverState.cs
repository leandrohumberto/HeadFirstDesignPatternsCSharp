namespace AccountManagement.States
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Silver indicates a non-interest bearing state
    /// </remarks>
    /// </summary>
    public class SilverState : State
    {

        public SilverState(State state) : this(state.Balance, state.Account) { }

        public SilverState(double balance, Account account)
        {
            Balance = balance;
            Account = account;
            Initialize();
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            Balance += Interest * Balance;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
            StateChangeCheck();
        }

        private void Initialize()
        {
            Interest = 0;
            LowerLimit = 0;
            UpperLimit = 1000;
        }

        private void StateChangeCheck()
        {
            if (Balance < LowerLimit)
            {
                Account.State = new RedState(this);
            }

            else if (Balance > UpperLimit)
            {
                Account.State = new GoldState(this);
            }
        }
    }
}
