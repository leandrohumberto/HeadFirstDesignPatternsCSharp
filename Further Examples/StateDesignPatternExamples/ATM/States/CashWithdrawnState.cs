namespace ATM.States
{
    public class CashWithdrawnState : ATMState
    {
        public CashWithdrawnState(ATMState state) : this(state.DummyCashPresent, state.Atm) { }

        public CashWithdrawnState(int amountRemaining, ATM atmBeingUsed)
        {
            DummyCashPresent = amountRemaining;
            Atm = atmBeingUsed;
        }

        public override string GetNextScreen()
        {
            UpdateState();
            return $"Thanks you for using us, Amount left in ATM: {DummyCashPresent.ToString()}";
        }

        private void UpdateState()
        {
            Atm.SetState(new NoCardState(this));
        }
    }
}
