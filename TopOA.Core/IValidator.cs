namespace TopOA.Core
{
    /// <summary>
    /// A reader or command handler inherits from this interface. It can be exposed to consumers, or it can serve as a reminder to implement Validate(T) then
    /// pull it up to a specific interface.
    /// </summary>
    public interface IValidator<in T>
    {
        /// <summary>Returns UserSettingsLogEventId.NoError iff the command or query passes validation.</summary>
        ErrorCode Validate(T commandOrQuery);
    }
}