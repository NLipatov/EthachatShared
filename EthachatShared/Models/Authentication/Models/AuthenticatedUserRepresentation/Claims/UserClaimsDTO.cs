#nullable disable

using MessagePack;

namespace EthachatShared.Models.Authentication.Models.AuthenticatedUserRepresentation.Claims
{
    [MessagePackObject]
    public class UserClaimsDto
    {
        [Key(0)]
        public string Name { get; set; }
        [Key(1)]
        public string Value { get; set; }
    }
}
