namespace TopOA.Core.Commands
{
    public class LoginCommand
    {
        private readonly string _token;

        public LoginCommand(string token)
        {
            _token = token;
        }
    }
}