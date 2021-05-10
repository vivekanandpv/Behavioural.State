using System.Collections.Generic;
using System.Text;

namespace Behavioural.State
{
    public abstract class State
    {
        protected readonly ICreditCardApplication _application;
        public State(ICreditCardApplication application)
        {
            _application = application;
        }

        public abstract void MoveToNextState();
        public abstract void MaveToPreviousState();
    }
}
