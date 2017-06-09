using System;
using Microsoft.Extensions.DependencyInjection;
using TopOA.Core;
using TopOA.Core.Commands;
using TopOA.Core.Readers;
using TopOA.Example.Console.IoC;

namespace TopOA.Example.Console
{
    public static class Program
    {
        /// <summary>The 24-hour token from the developer portal.</summary>
        private const string Token = "eyJhbGciOiJFUzI1NiIsIng1dCI6IkQ0QUU4MjQ2RDYyNTBFMTY5Njg4NDFCREY4Nzc2MTI4NUMwNUJCMUYifQ.eyJvYWEiOiI3Nzc3MCIsImlzcyI6Im9hIiwiYWlkIjoiMTA5IiwidWlkIjoianpkR0Zmc2tjV2lhUHVSZ0pXdVRZZz09IiwiY2lkIjoianpkR0Zmc2tjV2lhUHVSZ0pXdVRZZz09IiwiaXNhIjoiRmFsc2UiLCJ0aWQiOiIyMDAyIiwic2lkIjoiZDIwYTVlZmFhYjVlNDVjNmEzMTIyMzZiMzJhNDI5MDkiLCJkZ2kiOiI4NCIsImV4cCI6IjE0OTcwODM5NzAifQ.Q_gg9WMKMdGmw2D_X6TGVEz9Rni7X5TK_5jGNGJS6Gj9d-k_WXLZOZfzh1gtNtgSX-caeFjR_k6HlYx20e7ApQ";

        private static void Main()
        {
            // Use the .Net Core DI container:
            IServiceProvider serviceProvider = new DefaultCompositionRoot().Initialize();

            // Log in:
            var loginCommand = new LoginCommand(Token);
            var loginValidator = serviceProvider.GetService<IValidator<LoginCommand>>();
            if (loginValidator.Validate(loginCommand) != ErrorCode.NoError)
                return;
            var loginCommandHandler = serviceProvider.GetService<ICommandHandler<LoginCommand>>();
            loginCommandHandler.Execute(loginCommand);

            // Get a list of positions:
            var posistionsQuery = new PositionsQuery();
            var positionsValidator = serviceProvider.GetService<IValidator<PositionsQuery>>();
            if (positionsValidator.Validate(posistionsQuery) != ErrorCode.NoError)
                return;
            var positionsReader = serviceProvider.GetService<IQueryHandler<PositionsQuery, PositionsList>>();
            PositionsList positions = positionsReader.Query(posistionsQuery);
        }
    }
}