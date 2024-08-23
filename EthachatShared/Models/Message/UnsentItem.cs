namespace EthachatShared.Models.
    Message;

public record UnsentItem<T>
{
    public required T Item { get; set; }
    public TimeSpan Backoff { get; set; }
    public DateTime SendAfter { get; set; } = DateTime.UtcNow - TimeSpan.FromMinutes(1);
}