using EthachatShared.Models.Authentication.Types;
using MessagePack;

namespace EthachatShared.Models.Authentication.Models.Credentials.Implementation;

[MessagePackObject]
public class WebAuthnPair : ICredentials
{
    [Key(0)]
    public string CredentialId { get; set; } = string.Empty;
    [Key(1)]
    public uint Counter { get; set; }
    [Key(2)]
    public AuthenticationType Type => AuthenticationType.WebAuthn;
}