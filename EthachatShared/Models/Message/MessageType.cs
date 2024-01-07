namespace EthachatShared.Models.Message;

public enum MessageType
{
    UNSET,
    /// <summary>
    /// A message that user will see in GUI
    /// </summary>
    TextMessage,
    /// <summary>
    /// System message containing AES key proposal
    /// </summary>
    AesOffer,
    /// <summary>
    /// System message that is sent to accept AES key proposal
    /// </summary>
    AesAccept,
    DataPackage,
    Metadata,
    BlobLink
}
