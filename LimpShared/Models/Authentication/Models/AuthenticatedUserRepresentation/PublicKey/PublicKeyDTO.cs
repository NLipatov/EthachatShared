#nullable disable
using LimpShared.Models.Authentication.Types;

namespace LimpShared.Models.Authentication.Models.AuthenticatedUserRepresentation.PublicKey
{
    public class PublicKeyDto
    {
        public string Key { get; set; }
        public string Username { get; set; }
        public AuthenticationType AuthenticationType { get; set; }
    }
}
