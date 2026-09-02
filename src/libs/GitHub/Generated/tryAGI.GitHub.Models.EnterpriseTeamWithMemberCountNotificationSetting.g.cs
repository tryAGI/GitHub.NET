
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Whether team members will receive notifications when the team is mentioned.<br/>
    /// Example: notifications_enabled
    /// </summary>
    public enum EnterpriseTeamWithMemberCountNotificationSetting
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
    public static class EnterpriseTeamWithMemberCountNotificationSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterpriseTeamWithMemberCountNotificationSetting value)
        {
            return value switch
            {
                EnterpriseTeamWithMemberCountNotificationSetting.NotificationsDisabled => "notifications_disabled",
                EnterpriseTeamWithMemberCountNotificationSetting.NotificationsEnabled => "notifications_enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterpriseTeamWithMemberCountNotificationSetting? ToEnum(string value)
        {
            return value switch
            {
                "notifications_disabled" => EnterpriseTeamWithMemberCountNotificationSetting.NotificationsDisabled,
                "notifications_enabled" => EnterpriseTeamWithMemberCountNotificationSetting.NotificationsEnabled,
                _ => null,
            };
        }
    }
}