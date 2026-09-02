
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum CodeQualityListFindingsForRepoState
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
    public static class CodeQualityListFindingsForRepoStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualityListFindingsForRepoState value)
        {
            return value switch
            {
                CodeQualityListFindingsForRepoState.Dismissed => "dismissed",
                CodeQualityListFindingsForRepoState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualityListFindingsForRepoState? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => CodeQualityListFindingsForRepoState.Dismissed,
                "open" => CodeQualityListFindingsForRepoState.Open,
                _ => null,
            };
        }
    }
}