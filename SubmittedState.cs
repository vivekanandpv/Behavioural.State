namespace Behavioural.State
{
    public class SubmittedState : State
    {
        public SubmittedState(ICreditCardApplication application): base(application)
        {
        }

        public override void MaveToPreviousState()
        {
            
        }

        public override void MoveToNextState()
        {
            _application.ChangeState(_application.MakerAssigned);
        }
    }
}
