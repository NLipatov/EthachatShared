namespace EthachatShared.Models.Message;

public record HlsPlaylist
{
    public required string Name { get; set; }
    public required string M3U8Content { get; set; }
}