namespace LimpShared.Models.Authentication.Models;

public class WebAuthnPair
{
    public string CredentialId { get; set; }
    public uint Counter { get; set; }
}