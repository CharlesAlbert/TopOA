namespace TopOA.Core
{
    /// <summary>
    /// A reader (query handler) inherits from this interface. It can be exposed to consumers, or it can serve as a reminder to implement Query(TQuery) then
    /// pull it up to a specific interface.
    /// </summary>
    public interface IQueryHandler<in TQuery, out TResult>
    {
        TResult Query(TQuery query);
    }
}
