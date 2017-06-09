namespace TopOA.Core.Commands
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand>, IValidator<LoginCommand>
    {
        public void Execute(LoginCommand command)
        {
        }

        public ErrorCode Validate(LoginCommand commandOrQuery)
        {
            return ErrorCode.NoError;
        }
    }
}
