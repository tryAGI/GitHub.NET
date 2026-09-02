
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum RepositoryRuleLicenseComplianceScanningType
    {
        /// <summary>
        ///
        /// </summary>
        LicenseComplianceScanning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleLicenseComplianceScanningTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleLicenseComplianceScanningType value)
        {
            return value switch
            {
                RepositoryRuleLicenseComplianceScanningType.LicenseComplianceScanning => "license_compliance_scanning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleLicenseComplianceScanningType? ToEnum(string value)
        {
            return value switch
            {
                "license_compliance_scanning" => RepositoryRuleLicenseComplianceScanningType.LicenseComplianceScanning,
                _ => null,
            };
        }
    }
}