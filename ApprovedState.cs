using System;

namespace Behavioural.State
{
    public class ApprovedState : State
    {
        public ApprovedState(ICreditCardApplication application) : base(application)
        {
        }

        public override void MaveToPreviousState()
        {
            throw new NotImplementedException();
        }

        public override void MoveToNextState()
        {
            
        }
    }
}
