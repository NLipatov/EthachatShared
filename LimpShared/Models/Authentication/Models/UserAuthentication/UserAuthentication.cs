using LimpShared.Models.Authentication.Models.AuthenticatedUserRepresentation.Claims;

namespace LimpShared.Models.Authentication.Models.UserAuthentication;

public class UserAuthentication
{
    public string Username { get; set; } = "N/A";
    public string? Password { get; set; }
    public List<UserClaimsDTO>? Claims { get; set; }
}