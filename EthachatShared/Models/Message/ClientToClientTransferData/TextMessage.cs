using EthachatShared.Models.Message.Interfaces;
using MessagePack;

namespace EthachatShared.Models.Message.ClientToClientTransferData;

[MessagePackObject]
public record TextMessage : IIdentifiable, ISourceResolvable, IDestinationResolvable
{
    [Key(0)] public Guid Id { get; set; } = Guid.NewGuid();
    [Key(1)] public required string Sender { get; set; }
    [Key(2)] public string Text { get; set; } = string.Empty;
    [Key(3)] public int Index { get; set; } = 0;
    [Key(4)] public int Total { get; set; } = 1;
    [Key(5)] public required string Target { get; set; }
}