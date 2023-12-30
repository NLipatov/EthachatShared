#nullable disable
namespace EthachatShared.Models.Message.DataTransfer;

public record Package
{
    public Guid FileDataid { get; set; }
    public int Index { get; set; }
    public int Total { get; set; }
    public string B64Data { get; set; }
    public string ContentType { get; set; }
    public string FileName { get; set; }
    public string IV { get; set; }
}