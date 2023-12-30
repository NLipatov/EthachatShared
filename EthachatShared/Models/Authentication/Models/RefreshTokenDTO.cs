namespace EthachatShared.Models.Authentication.Models
{
    public record RefreshTokenDto
    {
        public string UserAgent { get; set; } = string.Empty;
        public Guid UserAgentId { get; set; }
        public RefreshToken? RefreshToken { get; set; }
    }
}