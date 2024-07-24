using EthachatShared.Encryption;

namespace EthachatShared.Models.Cryptograms;

public record BinaryCryptogram
{
    public byte[] Iv { get; init; } = [];
    public byte[] Cypher { get; init; } = [];
    public Guid KeyId { get; init; }
    public KeyType EncryptionKeyType { get; init; }
}