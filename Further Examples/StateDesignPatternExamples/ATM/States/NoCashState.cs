using System;

namespace ATM.States
{
    public class NoCashState : ATMState
    {
        public NoCashState(ATMState state) : this(state.DummyCashPresent, state.Atm) { }

        public NoCashState(int amountRemaining, ATM atmBeingUsed)
        {
            DummyCashPresent = amountRemaining;
            Atm = atmBeingUsed;
        }

        public override string GetNextScreen()
        {
            Console.WriteLine("ATM is EMPTY");
            Console.ReadLine();
            return string.Empty;
        }
    }
}
