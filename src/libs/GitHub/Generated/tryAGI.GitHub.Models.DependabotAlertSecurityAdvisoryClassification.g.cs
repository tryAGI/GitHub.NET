
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The classification of the advisory.<br/>
    /// Included only in responses
    /// </summary>
    public enum DependabotAlertSecurityAdvisoryClassification
    {
        /// <summary>
        ///
        /// </summary>
        General,
        /// <summary>
        ///
        /// </summary>
        Malware,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotAlertSecurityAdvisoryClassificationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertSecurityAdvisoryClassification value)
        {
            return value switch
            {
                DependabotAlertSecurityAdvisoryClassification.General => "general",
                DependabotAlertSecurityAdvisoryClassification.Malware => "malware",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertSecurityAdvisoryClassification? ToEnum(string value)
        {
            return value switch
            {
                "general" => DependabotAlertSecurityAdvisoryClassification.General,
                "malware" => DependabotAlertSecurityAdvisoryClassification.Malware,
                _ => null,
            };
        }
    }
}