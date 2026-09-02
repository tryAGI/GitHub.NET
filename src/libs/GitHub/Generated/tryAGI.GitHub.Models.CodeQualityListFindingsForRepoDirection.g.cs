
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum CodeQualityListFindingsForRepoDirection
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeQualityListFindingsForRepoDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeQualityListFindingsForRepoDirection value)
        {
            return value switch
            {
                CodeQualityListFindingsForRepoDirection.Asc => "asc",
                CodeQualityListFindingsForRepoDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeQualityListFindingsForRepoDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => CodeQualityListFindingsForRepoDirection.Asc,
                "desc" => CodeQualityListFindingsForRepoDirection.Desc,
                _ => null,
            };
        }
    }
}