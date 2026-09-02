
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of Copilot secret scanning
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecrets
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
        /// <summary>
        ///
        /// </summary>
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecrets value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecrets.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecrets.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecrets.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecrets? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecrets.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecrets.Enabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecrets.NotSet,
                _ => null,
            };
        }
    }
}