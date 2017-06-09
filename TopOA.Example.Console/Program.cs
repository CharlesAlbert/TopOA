using TopOA.Core;
using TopOA.Core.Commands;
using TopOA.Core.Readers;

namespace TopOA.Example.Console
{
    class Program
    {
        /// <summary>The 24-hour token from the developer portal.</summary>
        private const string Token = "eyJhbGciOiJFUzI1NiIsIng1dCI6IkQ0QUU4MjQ2RDYyNTBFMTY5Njg4NDFCREY4Nzc2MTI4NUMwNUJCMUYifQ.eyJvYWEiOiI3Nzc3MCIsImlzcyI6Im9hIiwiYWlkIjoiMTA5IiwidWlkIjoianpkR0Zmc2tjV2lhUHVSZ0pXdVRZZz09IiwiY2lkIjoianpkR0Zmc2tjV2lhUHVSZ0pXdVRZZz09IiwiaXNhIjoiRmFsc2UiLCJ0aWQiOiIyMDAyIiwic2lkIjoiZDIwYTVlZmFhYjVlNDVjNmEzMTIyMzZiMzJhNDI5MDkiLCJkZ2kiOiI4NCIsImV4cCI6IjE0OTcwODM5NzAifQ.Q_gg9WMKMdGmw2D_X6TGVEz9Rni7X5TK_5jGNGJS6Gj9d-k_WXLZOZfzh1gtNtgSX-caeFjR_k6HlYx20e7ApQ";

        static void Main(string[] _)
        {
            var loginCommand = new LoginCommand(Token);
            IValidator<LoginCommand> loginValidator = new LoginCommandHandler();
            if (loginValidator.Validate(loginCommand) != ErrorCode.NoError)
                return;

            var loginCommandHandler = (ICommandHandler<LoginCommand>)loginValidator;
            loginCommandHandler.Execute(loginCommand);

            var posistionsQuery = new PositionsQuery();
            IValidator<PositionsQuery> positionsValidator = new PositionsReader();
            if (positionsValidator.Validate(posistionsQuery) != ErrorCode.NoError)
                return;

            var positionsReader = (IQueryHandler<PositionsQuery, PositionsList>)positionsValidator;
            PositionsList positions = positionsReader.Query(posistionsQuery);
        }
    }
}