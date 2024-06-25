using MessagePack;

namespace EthachatShared.Encryption;

[MessagePackObject]
public class Key
{
    [Key(0)] public Guid Id { get; set; } = Guid.NewGuid();
    [Key(1)] public string Value { get; set; }
    [Key(2)] public KeyFormat? Format { get; set; }
    [Key(3)] public KeyType? Type { get; set; }
    [Key(4)] public string? Contact { get; set; }
    [Key(5)] public string? Author { get; set; }
    [Key(6)] public bool IsAccepted { get; set; } = false;
    [Key(7)] public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    [Key(8)] public Guid? OfferMessageId { get; set; }
    [Key(9)] public Guid? AcceptMessageId { get; set; }
}
