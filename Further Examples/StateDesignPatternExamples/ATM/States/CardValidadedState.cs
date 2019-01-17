using System;

namespace ATM.States
{
    public class CardValidadedState : ATMState
    {
        public CardValidadedState(ATMState state) : this(state.DummyCashPresent, state.Atm) { }

        public CardValidadedState(int amountRemaining, ATM atmBeingUsed)
        {
            DummyCashPresent = amountRemaining;
            Atm = atmBeingUsed;
        }

        public override string GetNextScreen()
        {
            string userInput = Console.ReadLine();

            int requestAmount;
            bool result = int.TryParse(userInput, out requestAmount);

            if (result)
            {
                if (DummyCashPresent < requestAmount)
                {
                    // Show only message and no change in state
                    return "Amount not present";
                }

                DummyCashPresent -= requestAmount;
                UpdateState();

                return $"Amount of {requestAmount} has been withdrawn. Press Enter to proceed";
            }

            // Show only message and no change in state
            return "Invalid Amount";
        }

        private void UpdateState()
        {
            if (DummyCashPresent == 0)
            {
                Atm.SetState(new NoCashState(this));
            }
            else
            {
                Atm.SetState(new CashWithdrawnState(this));
            }
        }
    }
}
