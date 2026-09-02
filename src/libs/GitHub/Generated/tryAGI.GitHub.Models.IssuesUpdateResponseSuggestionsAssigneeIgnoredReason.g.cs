
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesUpdateResponseSuggestionsAssigneeIgnoredReason
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
    public static class IssuesUpdateResponseSuggestionsAssigneeIgnoredReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateResponseSuggestionsAssigneeIgnoredReason value)
        {
            return value switch
            {
                IssuesUpdateResponseSuggestionsAssigneeIgnoredReason.AlreadyApplied => "already_applied",
                IssuesUpdateResponseSuggestionsAssigneeIgnoredReason.IssueAlreadyClosed => "issue_already_closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateResponseSuggestionsAssigneeIgnoredReason? ToEnum(string value)
        {
            return value switch
            {
                "already_applied" => IssuesUpdateResponseSuggestionsAssigneeIgnoredReason.AlreadyApplied,
                "issue_already_closed" => IssuesUpdateResponseSuggestionsAssigneeIgnoredReason.IssueAlreadyClosed,
                _ => null,
            };
        }
    }
}