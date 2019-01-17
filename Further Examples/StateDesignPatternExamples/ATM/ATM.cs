using ATM.States;
using System;

namespace ATM
{
    public class ATM
    {
        private ATMState _currentState;

        public ATM()
        {
            _currentState = new NoCardState(1000, this);
        }

        public void StartTheATM()
        {
            while (true)
            {
                Console.WriteLine(_currentState.GetNextScreen());
            }
        }

        public void SetState(ATMState state)
        {
            if (state == null) throw new ArgumentNullException(nameof(state));
            _currentState = state;
        }
    }
}
