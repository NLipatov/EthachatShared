#nullable disable
namespace LimpShared.Models.Message.DataTransfer;

public record Package
{
    public Guid FileDataid { get; set; }
    public int Index { get; set; }
    public int Total { get; set; }
    public string B64Data { get; set; }
}