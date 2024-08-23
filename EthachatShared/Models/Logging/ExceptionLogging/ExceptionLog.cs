using MessagePack;

namespace EthachatShared.Models.Logging.ExceptionLogging;

[MessagePackObject]
public record ExceptionLog : Log
{
    [Key(0)]
    public string? StackTrace { get; set; }
}