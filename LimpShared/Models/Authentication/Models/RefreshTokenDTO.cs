#nullable disable
namespace LimpShared.Models.Authentication.Models;

public record RefreshTokenDTO
{
    public string UserAgent { get; set; }
    public RefreshToken RefreshToken { get; set; }
}