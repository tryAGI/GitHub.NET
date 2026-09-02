
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Code quality setup has been configured or not.
    /// </summary>
    public enum CodeQualitySetupState
    {
        /// <summary>
        ///
        /// </summary>
        Configured,
        /// <summary>
        ///
        /// </summary>
        NotConfigured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeQualitySetupStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualitySetupState value)
        {
            return value switch
            {
                CodeQualitySetupState.Configured => "configured",
                CodeQualitySetupState.NotConfigured => "not-configured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualitySetupState? ToEnum(string value)
        {
            return value switch
            {
                "configured" => CodeQualitySetupState.Configured,
                "not-configured" => CodeQualitySetupState.NotConfigured,
                _ => null,
            };
        }
    }
}