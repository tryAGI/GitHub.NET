
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// State of a code scanning alert instance.
    /// </summary>
    public enum CodeScanningAlertInstanceState
    {
        /// <summary>
        ///
        /// </summary>
        Fixed,
        /// <summary>
        ///
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningAlertInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertInstanceState value)
        {
            return value switch
            {
                CodeScanningAlertInstanceState.Fixed => "fixed",
                CodeScanningAlertInstanceState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertInstanceState? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => CodeScanningAlertInstanceState.Fixed,
                "open" => CodeScanningAlertInstanceState.Open,
                _ => null,
            };
        }
    }
}