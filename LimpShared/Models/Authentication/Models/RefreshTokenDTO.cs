#nullable disable
namespace LimpShared.Models.Authentication.Models;

public record RefreshTokenDto
{
    public Guid UserAgent { get; set; }
    public RefreshToken RefreshToken { get; set; }
}