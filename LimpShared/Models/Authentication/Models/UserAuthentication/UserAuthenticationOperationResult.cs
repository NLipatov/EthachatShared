using System.Text.Json.Serialization;
using LimpShared.Models.Authentication.Enums;

namespace LimpShared.Models.Authentication.Models.UserAuthentication;

public class UserAuthenticationOperationResult
{
    [JsonPropertyName("systemMessage")]
    public string? SystemMessage { get; set; }
    [JsonPropertyName("userDTO")]
    public UserAuthentication? UserDTO { get; set; }
    [JsonPropertyName("result")]
    public OperationResultType ResultType { get; set; }
}
