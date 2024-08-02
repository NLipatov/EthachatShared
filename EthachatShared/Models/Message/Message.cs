using System.Text.Json;
using EthachatShared.Models.Cryptograms;
using EthachatShared.Models.Message.DataTransfer;
using EthachatShared.Models.Message.Interfaces;
using EthachatShared.Models.Message.TransferStatus;
using MessagePack;

namespace EthachatShared.Models.Message;

[MessagePackObject]
public class Message : IDestinationResolvable, ISourceResolvable, IDescribeable, IIdentifiable
{
    [Key(0)] public HlsPlaylist? HlsPlaylist { get; set; }
    [Key(1)] public SyncItem? SyncItem { get; set; }
    [Key(2)] public Metadata? Metadata { get; set; }
    [Key(3)] public Package? Package { get; set; }
    [Key(4)] public string BlobLink { get; set; }
    [Key(5)] public Guid Id { get; set; } = Guid.NewGuid();
    [Key(6)] public string Target { get; set; }
    [Key(7)] public string? SenderConnectionId { get; set; }
    [Key(8)] public string? CompanionConnectionId { get; set; }
    [Key(9)] public string Sender { get; set; }
    [Key(10)] public TextCryptogram? Cryptogramm { get; set; }
    [Key(11)] public bool IsDelivered { get; set; } = false;
    [Key(12)] public DateTime DateReceived { get; set; }
    [Key(13)] public bool IsSeen { get; set; } = false;
    [Key(14)] public DateTime DateRead { get; set; }
    [Key(15)] public DateTime DateSent { get; set; } = DateTime.UtcNow;
    [Key(16)] public MessageType Type { get; set; }
    [Key(17)] public bool IsRegisteredByHub { get; set; }

    public Message Clone()
    {
        return JsonSerializer
            .Deserialize<Message>
            (JsonSerializer.Serialize(this))!;
    }

    public string ItemDescription()
    {
        return Type switch
        {
            MessageType.Metadata => "file",
            _ => "message"
        };
    }
}
