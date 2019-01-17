namespace ATM.States
{
    public abstract class ATMState
    {
        public ATM Atm { get; set; }

        public int DummyCashPresent { get; set; } = 1000;

        public abstract string GetNextScreen();
    }
}
