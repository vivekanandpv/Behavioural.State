using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioural.State
{
    public class CreditCardApplication: ICreditCardApplication
    {
        //States: Submitted > Maker Assigned > Makes Verified > Checker Verified > Approved > Printing > Printed > Dispatched
        public int ApplicationNumber { get; set; }

        //  these are the possible states
        private readonly State _submitted;
        private readonly State _makerAssigned;
        private readonly State _makerVerified;
        private readonly State _checkerVerified;
        private readonly State _approved;

        //  this is the real state
        private State _currentState;

        public CreditCardApplication()
        {
            this._submitted = new SubmittedState(this);
            this._makerAssigned = new MakerAssignedState(this);
            this._makerVerified = new MakerVerifiedState(this);
            this._checkerVerified = new CheckerVerifiedState(this);
            this._approved = new ApprovedState(this);

            //  initial state
            this._currentState = _submitted;
        }


        public void ChangeState(State nextState)
        {
            this._currentState = nextState;
        }

        //  maker, checker, admin
        public void ProcessRequest()
        {
            //  change the state here!
            this._currentState.MoveToNextState();
        }

        State ICreditCardApplication.Submitted => this._submitted;

        State ICreditCardApplication.MakerAssigned => this._makerAssigned;

        State ICreditCardApplication.MakerVerified => this._makerVerified;

        State ICreditCardApplication.CheckerVerified => this._checkerVerified;

        State ICreditCardApplication.Approved => this._approved;

        public override string ToString()
        {
            return $"Application: {ApplicationNumber} : Current State: {this._currentState}";
        }
    }
}
