
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enablement status of Copilot secret scanning<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets
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
    public static class CodeSecurityCreateConfigurationRequestSecretScanningGenericSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets.Disabled,
                "enabled" => CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets.Enabled,
                "not_set" => CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets.NotSet,
                _ => null,
            };
        }
    }
}