# TopOA

The Top OA C# library makes it easy to start coding with the Saxo Bank REST Open API.

Based on the Command Query Responsibility Separation (CQRS) principle, any operation is a matter of executing a command or issuing a query.

For example, in order to log on, then read a list of all positions, do this,
```csharp
            // Use the .Net Core DI container:
            IServiceProvider serviceProvider = new DefaultCompositionRoot().Initialize();

            // Log in:
            var loginCommand = new LoginCommand(Token);
            var loginCommandHandler = serviceProvider.GetService<ICommandHandler<LoginCommand>>();
            loginCommandHandler.Execute(loginCommand);

            // Get a list of positions:
            var posistionsQuery = new PositionsQuery();
            var positionsReader = serviceProvider.GetService<IQueryHandler<PositionsQuery, PositionsList>>();
            PositionsList positions = positionsReader.Query(posistionsQuery);
```

Validation and DI container setup has been omitted in the above snippet. The full examples are included in the repository.
