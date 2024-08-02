namespace EthachatShared.Constants;

public abstract record HubAddress
{
    public const string Users = "/usersHub";
    public const string Message = "/messageDispatcherHub";
    public const string Auth = "/authHub";
    public const string ExceptionLogging = "/loggingHub";
}