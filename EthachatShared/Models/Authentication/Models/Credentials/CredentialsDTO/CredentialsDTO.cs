using EthachatShared.Models.Authentication.Models.Credentials.Implementation;
using MessagePack;

namespace EthachatShared.Models.Authentication.Models.Credentials.CredentialsDTO;

[MessagePackObject]
public record CredentialsDTO
{
    [Key(0)]
    public JwtPair? JwtPair { get; set; }
    [Key(1)]
    public WebAuthnPair? WebAuthnPair { get; set; }
}