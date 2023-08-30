#nullable disable
namespace LimpShared.Models.Authentication.Models;

public record RefreshTokenDto
{
    public string UserAgent { get; set; }
    public RefreshToken RefreshToken { get; set; }
}