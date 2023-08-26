namespace LimpShared.Models.Authentication.Models
{
    public class AuthResult
    {
        public string? Message { get; set; }
        public AuthResultType? Result { get; set; }
        public JwtPair? JwtPair { get; set; }
    }
}
