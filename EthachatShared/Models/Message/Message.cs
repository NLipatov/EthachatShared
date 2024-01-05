using System;
using System.Text.Json;
using EthachatShared.Contracts;
using EthachatShared.Models.Message.DataTransfer;

namespace EthachatShared.Models.Message;

public class Message : ICloneable<Message>
{
    public Metadata? Metadata { get; set; }
    public Package? Package { get; set; }
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? TargetGroup { get; set; }
    public string? SenderConnectionId { get; set; }
    public string? CompanionConnectionId { get; set; }
    public string? Sender { get; set; }
    public Cryptogramm? Cryptogramm { get; set; }
    public bool IsDelivered { get; set; } = false;
    public DateTime DateReceived { get; set; }
    public bool IsSeen { get; set; } = false;
    public DateTime DateRead { get; set; }
    public DateTime DateSent { get; set; }
    public MessageType Type { get; set; }
    public bool IsRegisteredByHub { get; set; }

    public Message Clone()
    {
        return JsonSerializer
            .Deserialize<Message>
            (JsonSerializer.Serialize(this))!;
    }
}
