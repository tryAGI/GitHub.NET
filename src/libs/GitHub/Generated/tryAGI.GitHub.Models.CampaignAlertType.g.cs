
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Indicates the alert type of a campaign
    /// </summary>
    public enum CampaignAlertType
    {
        /// <summary>
        ///
        /// </summary>
        CodeScanning,
        /// <summary>
        ///
        /// </summary>
        SecretScanning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignAlertTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignAlertType value)
        {
            return value switch
            {
                CampaignAlertType.CodeScanning => "code_scanning",
                CampaignAlertType.SecretScanning => "secret_scanning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignAlertType? ToEnum(string value)
        {
            return value switch
            {
                "code_scanning" => CampaignAlertType.CodeScanning,
                "secret_scanning" => CampaignAlertType.SecretScanning,
                _ => null,
            };
        }
    }
}