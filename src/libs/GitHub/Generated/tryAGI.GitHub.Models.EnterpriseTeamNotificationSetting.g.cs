
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Whether team members will receive notifications when the team is mentioned.<br/>
    /// Example: notifications_enabled
    /// </summary>
    public enum EnterpriseTeamNotificationSetting
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
    public static class EnterpriseTeamNotificationSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterpriseTeamNotificationSetting value)
        {
            return value switch
            {
                EnterpriseTeamNotificationSetting.NotificationsDisabled => "notifications_disabled",
                EnterpriseTeamNotificationSetting.NotificationsEnabled => "notifications_enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterpriseTeamNotificationSetting? ToEnum(string value)
        {
            return value switch
            {
                "notifications_disabled" => EnterpriseTeamNotificationSetting.NotificationsDisabled,
                "notifications_enabled" => EnterpriseTeamNotificationSetting.NotificationsEnabled,
                _ => null,
            };
        }
    }
}