
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// State of the code quality finding.
    /// </summary>
    public enum CodeQualityFindingState
    {
        /// <summary>
        ///
        /// </summary>
        Dismissed,
        /// <summary>
        ///
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeQualityFindingStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualityFindingState value)
        {
            return value switch
            {
                CodeQualityFindingState.Dismissed => "dismissed",
                CodeQualityFindingState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualityFindingState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => CodeQualityFindingState.Dismissed,
                "open" => CodeQualityFindingState.Open,
                _ => null,
            };
        }
    }
}