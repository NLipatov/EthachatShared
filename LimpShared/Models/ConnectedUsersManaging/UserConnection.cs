#nullable disable
using ClientServerCommon;
using LimpShared.Encryption;

namespace LimpShared.Models.ConnectedUsersManaging
{
    public class UserConnection
    {
        public string Username { get; set; }
        public Key RSAPublicKey { get; set; }
        public IList<string> ConnectionIds { get; set; }
    }
}
