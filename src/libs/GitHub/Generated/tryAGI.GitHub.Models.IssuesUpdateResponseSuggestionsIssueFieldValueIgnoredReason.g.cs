
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesUpdateResponseSuggestionsIssueFieldValueIgnoredReason
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
    public static class IssuesUpdateResponseSuggestionsIssueFieldValueIgnoredReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateResponseSuggestionsIssueFieldValueIgnoredReason value)
        {
            return value switch
            {
                IssuesUpdateResponseSuggestionsIssueFieldValueIgnoredReason.AlreadyApplied => "already_applied",
                IssuesUpdateResponseSuggestionsIssueFieldValueIgnoredReason.IssueAlreadyClosed => "issue_already_closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateResponseSuggestionsIssueFieldValueIgnoredReason? ToEnum(string value)
        {
            return value switch
            {
                "already_applied" => IssuesUpdateResponseSuggestionsIssueFieldValueIgnoredReason.AlreadyApplied,
                "issue_already_closed" => IssuesUpdateResponseSuggestionsIssueFieldValueIgnoredReason.IssueAlreadyClosed,
                _ => null,
            };
        }
    }
}