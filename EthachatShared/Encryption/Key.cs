using MessagePack;

namespace EthachatShared.Encryption;

[MessagePackObject]
public class Key
{
    [Key(0)] public required Guid Id { get; init; }
    [Key(1)] public required string Value { get; init; }
    [Key(2)] public KeyFormat? Format { get; init; }
    [Key(3)] public KeyType? Type { get; init; }
    [Key(4)] public string? Contact { get; set; }
    [Key(5)] public string? Author { get; set; }
    [Key(6)] public bool IsAccepted { get; set; }
    [Key(7)] public DateTime CreationDate { get; init; } = DateTime.UtcNow;
}
