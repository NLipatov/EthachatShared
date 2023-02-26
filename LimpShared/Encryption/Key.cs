namespace LimpShared.Encryption;

public class Key
{
    public object? Value { get; set; }
    public KeyFormat? Format { get; set; }
    public KeyType? Type { get; set; }
    public string? Contact { get; set; }
}
