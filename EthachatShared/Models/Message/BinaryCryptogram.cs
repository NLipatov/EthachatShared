using EthachatShared.Encryption;

namespace EthachatShared.Models.Message;

public class BinaryCryptogram
{
    public byte[] Iv { get; set; }
    public byte[] Cypher { get; set; }
    public Guid KeyId { get; set; }
    public KeyType EncryptionKeyType { get; set; }
}