using AuthAPI.DTOs.User;

namespace LimpShared.DTOs.User;

public class UserResponse
{
    public string? SystemMessage { get; set; }
    public UserDTO? UserDTO { get; set; }
}
