
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesUpdateResponseSuggestionsStateItemIgnoredReason
    {
        /// <summary>
        ///
        /// </summary>
        AlreadyApplied,
        /// <summary>
        ///
        /// </summary>
        IssueAlreadyClosed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesUpdateResponseSuggestionsStateItemIgnoredReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateResponseSuggestionsStateItemIgnoredReason value)
        {
            return value switch
            {
                IssuesUpdateResponseSuggestionsStateItemIgnoredReason.AlreadyApplied => "already_applied",
                IssuesUpdateResponseSuggestionsStateItemIgnoredReason.IssueAlreadyClosed => "issue_already_closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateResponseSuggestionsStateItemIgnoredReason? ToEnum(string value)
        {
            return value switch
            {
                "already_applied" => IssuesUpdateResponseSuggestionsStateItemIgnoredReason.AlreadyApplied,
                "issue_already_closed" => IssuesUpdateResponseSuggestionsStateItemIgnoredReason.IssueAlreadyClosed,
                _ => null,
            };
        }
    }
}