using AuthAPI.DTOs.User;
using LimpShared.ResultTypeEnum;
using System.Text.Json.Serialization;

namespace LimpShared.DTOs.User;

public class UserOperationResult
{
    [JsonPropertyName("systemMessage")]
    public string? SystemMessage { get; set; }
    [JsonPropertyName("userDTO")]
    public UserDTO? UserDTO { get; set; }
    [JsonPropertyName("result")]
    public OperationResultType ResultType { get; set; }
}
