﻿namespace LimpShared.Models.WebPushNotification
{
    public class NotificationSubscription
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string? AccessToken { get; set; }

        public string? Url { get; set; }

        public string? P256dh { get; set; }

        public string? Auth { get; set; }
    }
}
