namespace LimpShared.Models.Authentication.Models
{
    public class AuthResult
    {
        public string? Message { get; set; }
        public AuthResultType? Result { get; set; }
        public JWTPair? JWTPair { get; set; }
    }
}
