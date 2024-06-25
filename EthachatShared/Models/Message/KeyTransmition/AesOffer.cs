using EthachatShared.Encryption;
using EthachatShared.Models.Message.Interfaces;
using MessagePack;

namespace EthachatShared.Models.Message.KeyTransmition;

[MessagePackObject]
public class AesOffer : IDestinationResolvable, ISourceResolvable, IIdentifiable
{
    [Key(0)] public Guid Id { get; set; }
    [Key(1)] public required string Target { get; set; }
    [Key(2)] public required string Sender { get; set; }
    [Key(3)] public Key key { get; set; }
    [Key(4)] public string PassPhrase { get; set; }
}