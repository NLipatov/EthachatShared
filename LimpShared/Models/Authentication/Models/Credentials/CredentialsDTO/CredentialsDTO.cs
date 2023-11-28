using LimpShared.Models.Authentication.Models.Credentials.Implementation;

namespace LimpShared.Models.Authentication.Models.Credentials.CredentialsDTO;

public record CredentialsDTO
{
    public JwtPair? JwtPair { get; set; }
    public WebAuthnPair? WebAuthnPair { get; set; }
}