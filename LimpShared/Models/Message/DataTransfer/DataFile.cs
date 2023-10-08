#nullable disable
namespace LimpShared.Models.Message.DataTransfer;

public record DataFile
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FileName { get; set; }
    public List<Package> Packages { get; set; } = new();
}