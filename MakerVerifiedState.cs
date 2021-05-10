﻿using System;

namespace Behavioural.State
{
    public class MakerVerifiedState : State
    {
        public MakerVerifiedState(ICreditCardApplication application) : base(application)
        {
        }

        public override void MaveToPreviousState()
        {
            throw new NotImplementedException();
        }

        public override void MoveToNextState()
        {
            _application.ChangeState(_application.CheckerVerified);
        }
    }
}
