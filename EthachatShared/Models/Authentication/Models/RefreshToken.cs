using MessagePack;

namespace EthachatShared.Models.Authentication.Models
{
    [MessagePackObject]
    public class RefreshToken
    {
        [Key(0)]
        public DateTime Created { get; set; }
        [Key(1)]
        public DateTime Expires { get; set; }
        [Key(2)]
        public string? Token { get; set; }
    }
}