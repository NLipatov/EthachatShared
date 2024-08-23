using EthachatShared.Models.Authentication.Models.Credentials.Implementation;
using MessagePack;

namespace EthachatShared.Models.WebPushNotification
{
    [MessagePackObject]
    public record NotificationSubscriptionDto
    {
        [Key(0)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Key(1)]
        public JwtPair? JwtPair { get; set; }
        [Key(2)]
        public WebAuthnPair? WebAuthnPair { get; set; }
        [Key(3)]
        public string? Url { get; set; }
        [Key(4)]
        public string? P256dh { get; set; }
        [Key(5)]
        public string? Auth { get; set; }
        [Key(6)]
        public Guid UserAgentId { get; set; }
        [Key(7)]
        public string? FirebaseRegistrationToken { get; set; }
    }
}
