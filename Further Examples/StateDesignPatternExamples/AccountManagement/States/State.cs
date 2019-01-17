namespace AccountManagement.States
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    public abstract class State
    {
        protected double Interest { get; set; }
        protected double LowerLimit { get; set; }
        protected double UpperLimit { get; set; }

        public Account Account { get; set; }
        
        public double Balance { get; set; }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }
}
