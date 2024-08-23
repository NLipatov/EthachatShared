#nullable disable

using EthachatShared.Models.Authentication.Types;
using MessagePack;

namespace EthachatShared.Models.Authentication.Models.Credentials.Implementation
{
    [MessagePackObject]
    public class JwtPair : ICredentials
    {
        [Key(0)]
        public string AccessToken { get; set; }
        [Key(1)]
        public RefreshToken RefreshToken { get; set; }
        [Key(2)]
        public AuthenticationType Type => AuthenticationType.JwtToken;
    }
}
