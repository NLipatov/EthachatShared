using EthachatShared.Encryption;

namespace EthachatShared.Models.Cryptograms
{
    public record TextCryptogram
    {
        public string? Iv { get; init; }
        public string? Cyphertext { get; init; }
        public Guid KeyId { get; set; }
        public KeyType EncryptionKeyType { get; set; }
    }
}
