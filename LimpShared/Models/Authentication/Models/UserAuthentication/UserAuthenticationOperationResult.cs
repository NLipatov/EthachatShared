using LimpShared.Models.AuthenticationModels.ResultTypeEnum;
using System.Text.Json.Serialization;

namespace LimpShared.Models.Authentication.Models.UserAuthentication;

public class UserAuthenticationOperationResult
{
    [JsonPropertyName("systemMessage")]
    public string? SystemMessage { get; set; }
    [JsonPropertyName("userDTO")]
    public UserAuthentication? UserDto { get; set; }
    [JsonPropertyName("result")]
    public OperationResultType ResultType { get; set; }
}
