namespace LimpShared.Encryption;

public class Key
{
    public object? Value { get; set; }
    public KeyFormat? Format { get; set; }
    public KeyType? Type { get; set; }
    public string? Contact { get; set; }
    public string? Author { get; set; }
    public bool IsAccepted { get; set; } = false;
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
}
