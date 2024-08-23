namespace EthachatShared.Models.Message;

public class ClientToServerData
{
    public Guid Id { get; init; }
    public required string EventName { get; init; }
    public byte[] Data { get; init; } = [];
    public Type? Type { get; init; } = null;
}