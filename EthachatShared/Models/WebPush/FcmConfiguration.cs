namespace EthachatShared.Models.WebPush;

public class FcmConfiguration
{
    public required string ApiKey { get; set; }
    public required string AuthDomain { get; set; }
    public required string ProjectId { get; set; }
    public required string StorageBucket { get; set; }
    public required string MessagingSenderId { get; set; }
    public required string AppId { get; set; }
    public required string PublicVapidKey { get; set; }
    
}