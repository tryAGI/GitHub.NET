
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesUpdateResponseSuggestionsLabelIgnoredReason
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
    public static class IssuesUpdateResponseSuggestionsLabelIgnoredReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateResponseSuggestionsLabelIgnoredReason value)
        {
            return value switch
            {
                IssuesUpdateResponseSuggestionsLabelIgnoredReason.AlreadyApplied => "already_applied",
                IssuesUpdateResponseSuggestionsLabelIgnoredReason.IssueAlreadyClosed => "issue_already_closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateResponseSuggestionsLabelIgnoredReason? ToEnum(string value)
        {
            return value switch
            {
                "already_applied" => IssuesUpdateResponseSuggestionsLabelIgnoredReason.AlreadyApplied,
                "issue_already_closed" => IssuesUpdateResponseSuggestionsLabelIgnoredReason.IssueAlreadyClosed,
                _ => null,
            };
        }
    }
}