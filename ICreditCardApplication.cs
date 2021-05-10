namespace Behavioural.State
{
    public interface ICreditCardApplication
    {
        State Submitted { get; }
        State MakerAssigned { get; }
        State MakerVerified { get; }
        State CheckerVerified { get; }
        State Approved { get; }
        void ChangeState(State nextState);
    }
}
