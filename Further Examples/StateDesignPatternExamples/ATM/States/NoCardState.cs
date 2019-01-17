using System;

namespace ATM.States
{
    public class NoCardState : ATMState
    {

        public NoCardState(ATMState state) : this(state.DummyCashPresent, state.Atm) { }

        public NoCardState(int amountRemaining, ATM atmBeingUsed)
        {
            DummyCashPresent = amountRemaining;
            Atm = atmBeingUsed;
        }

        public override string GetNextScreen()
        {
            Console.WriteLine("Please enter your PIN: ");
            string userInput = Console.ReadLine();

            // Let's check with the dummy PIN
            if (userInput.Trim() == "1234")
            {
                UpdateState();
                return "Enter the Amount to Withdraw";
            }
            
            // Show only message and no change in state
            return "Invalid PIN";
        }

        private void UpdateState()
        {
            Atm.SetState(new CardValidadedState(this));
        }
    }
}
