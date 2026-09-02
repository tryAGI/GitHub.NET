
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The notification setting the team is set to. The options are:<br/>
    /// * `notifications_enabled` - team members receive notifications when the team is @mentioned.<br/>
    /// * `notifications_disabled` - no one receives notifications.
    /// </summary>
    public enum EnterpriseTeamsUpdateRequestNotificationSetting
    {
        /// <summary>
        ///
        /// </summary>
        NotificationsDisabled,
        /// <summary>
        ///
        /// </summary>
        NotificationsEnabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnterpriseTeamsUpdateRequestNotificationSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterpriseTeamsUpdateRequestNotificationSetting value)
        {
            return value switch
            {
                EnterpriseTeamsUpdateRequestNotificationSetting.NotificationsDisabled => "notifications_disabled",
                EnterpriseTeamsUpdateRequestNotificationSetting.NotificationsEnabled => "notifications_enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterpriseTeamsUpdateRequestNotificationSetting? ToEnum(string value)
        {
            return value switch
            {
                "notifications_disabled" => EnterpriseTeamsUpdateRequestNotificationSetting.NotificationsDisabled,
                "notifications_enabled" => EnterpriseTeamsUpdateRequestNotificationSetting.NotificationsEnabled,
                _ => null,
            };
        }
    }
}