
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum SecurityAndAnalysisCodeSecurityStatus
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAndAnalysisCodeSecurityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAndAnalysisCodeSecurityStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisCodeSecurityStatus.Disabled => "disabled",
                SecurityAndAnalysisCodeSecurityStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisCodeSecurityStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecurityAndAnalysisCodeSecurityStatus.Disabled,
                "enabled" => SecurityAndAnalysisCodeSecurityStatus.Enabled,
                _ => null,
            };
        }
    }
}