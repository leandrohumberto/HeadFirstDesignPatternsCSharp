using Structural.States;
using System;

namespace Structural
{
    /// <summary>
    /// The "Context" class
    /// </summary>
    public class Context
    {
        private State state;

        public Context(State state)
        {
            this.state = state;
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State: {0}", state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }

    }
}
