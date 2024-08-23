using EthachatShared.Models.Authentication.Models.AuthenticatedUserRepresentation.Claims;
using MessagePack;

namespace EthachatShared.Models.Authentication.Models.UserAuthentication;

[MessagePackObject]
public class UserAuthentication
{
    [Key(0)]
    public string Username { get; set; } = "N/A";
    [Key(1)]
    public string? Password { get; set; }
    [Key(2)]
    public List<UserClaimsDto>? Claims { get; set; }
    [Key(3)]
    public string UserAgent { get; set; } = string.Empty;
    [Key(4)]
    public Guid UserAgentId { get; set; }
}