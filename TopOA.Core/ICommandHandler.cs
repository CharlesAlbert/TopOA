namespace TopOA.Core
{
    /// <summary>
    /// A command handler inherits from this interface. It can be exposed to consumers, or it can serve as a reminder to implement Execute(TCommand) then
    /// pull it up to a specific interface.
    /// </summary>
    public interface ICommandHandler<in TCommand>
    {
        void Execute(TCommand command);
    }
}