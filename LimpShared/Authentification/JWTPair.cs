#nullable disable
using AuthAPI;
using System.Text.Json.Serialization;

namespace LimpShared.Authentification
{
    public class JWTPair
    {
        public string AccessToken { get; set; }
        public RefreshToken RefreshToken { get; set; }
    }
}
