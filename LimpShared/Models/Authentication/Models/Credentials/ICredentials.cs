using LimpShared.Models.Authentication.Types;

namespace LimpShared.Models.Authentication.Models.Credentials;

public interface ICredentials
{
    public AuthenticationType Type { get; }
}