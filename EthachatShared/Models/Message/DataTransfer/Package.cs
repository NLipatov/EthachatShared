#nullable disable
using EthachatShared.Models.Message.Interfaces;
using MessagePack;

namespace EthachatShared.Models.Message.DataTransfer;

[MessagePackObject]
public record Package : IDestinationResolvable, ISourceResolvable, IIdentifiable
{
    [Key(0)] public Guid Id { get; set; }
    [Key(1)] public string Target { get; set; }
    [Key(2)] public string Sender { get; set; }
    [Key(3)] public Guid FileDataid { get; set; }
    [Key(4)] public int Index { get; set; }
    [Key(5)] public int Total { get; set; }
    [Key(6)] public byte[] Data { get; set; }
    [Key(7)] public string Iv { get; set; }
    [Key(8)] public string ContentType { get; set; }
    [Key(9)] public string Filename { get; set; }
}