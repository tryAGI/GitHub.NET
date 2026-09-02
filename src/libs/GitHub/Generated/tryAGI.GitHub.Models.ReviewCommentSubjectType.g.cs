
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The level at which the comment is targeted, can be a diff line or a file.
    /// </summary>
    public enum ReviewCommentSubjectType
    {
        /// <summary>
        ///
        /// </summary>
        File,
        /// <summary>
        ///
        /// </summary>
        Line,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewCommentSubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewCommentSubjectType value)
        {
            return value switch
            {
                ReviewCommentSubjectType.File => "file",
                ReviewCommentSubjectType.Line => "line",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewCommentSubjectType? ToEnum(string value)
        {
            return value switch
            {
                "file" => ReviewCommentSubjectType.File,
                "line" => ReviewCommentSubjectType.Line,
                _ => null,
            };
        }
    }
}