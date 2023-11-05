#nullable disable

using LimpShared.Models.Authentication.Types;

namespace LimpShared.Models.Authentication.Models.Credentials.Implementation
{
    public class JwtPair : ICredentials
    {
        public string AccessToken { get; set; }
        public RefreshToken RefreshToken { get; set; }
        public AuthenticationType Type => AuthenticationType.JwtToken;
    }
}
