namespace LimpShared.Models.Authentication.Models;

public class RefreshCredentialIdDto
{
    public string CredentialId { get; set; }
    public uint Counter { get; set; }
}