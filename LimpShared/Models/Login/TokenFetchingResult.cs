using LimpShared.Authentification;

namespace LimpShared.Models.Login
{
    public class TokenFetchingResult
    {
        public string? Message { get; set; }
        public TokenAquisitionResult Result { get; set; }
        public JWTPair? JWTPair { get; set; }
    }
}
