# TopOA

The Top OA C# library makes it easy to start coding with the Saxo Bank REST Open API.

Based on the Command Query Responsibility Separation (CQRS) principle, any operation is a matter of executing a command or issuing a query.

For example, in order to log on, then read a list of all positions, do this,
```csharp
  loginCommandHandler.Execute(loginCommand);
  PositionsList positions = positionsReader.Query(posistionsQuery);
```

Full examples are included in the repository.
