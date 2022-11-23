#nullable disable
using AuthAPI;

namespace LimpShared.Authentification
{
    public class JWTPair
    {
        public string AccessToken { get; set; }
        public RefreshToken RefreshToken { get; set; }
    }
}
