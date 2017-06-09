using System;

namespace TopOA.Core.Commands
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand>, IValidator<LoginCommand>
    {
        public void Execute(LoginCommand command)
        {
            throw new NotImplementedException();
        }

        public ErrorCode Validate(LoginCommand commandOrQuery)
        {
            throw new NotImplementedException();
        }
    }
}
