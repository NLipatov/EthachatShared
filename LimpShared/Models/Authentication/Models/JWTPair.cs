#nullable disable

using LimpShared;

namespace LimpShared.Models.Authentication.Models
{
    public class JwtPair
    {
        public string AccessToken { get; set; }
        public RefreshToken RefreshToken { get; set; }
    }
}
