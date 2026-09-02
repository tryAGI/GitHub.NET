
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesListSuggestionsAction
    {
        /// <summary>
        ///
        /// </summary>
        AddAssignee,
        /// <summary>
        ///
        /// </summary>
        AddField,
        /// <summary>
        ///
        /// </summary>
        AddLabel,
        /// <summary>
        ///
        /// </summary>
        CloseIssue,
        /// <summary>
        ///
        /// </summary>
        SetType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListSuggestionsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListSuggestionsAction value)
        {
            return value switch
            {
                IssuesListSuggestionsAction.AddAssignee => "add_assignee",
                IssuesListSuggestionsAction.AddField => "add_field",
                IssuesListSuggestionsAction.AddLabel => "add_label",
                IssuesListSuggestionsAction.CloseIssue => "close_issue",
                IssuesListSuggestionsAction.SetType => "set_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListSuggestionsAction? ToEnum(string value)
        {
            return value switch
            {
                "add_assignee" => IssuesListSuggestionsAction.AddAssignee,
                "add_field" => IssuesListSuggestionsAction.AddField,
                "add_label" => IssuesListSuggestionsAction.AddLabel,
                "close_issue" => IssuesListSuggestionsAction.CloseIssue,
                "set_type" => IssuesListSuggestionsAction.SetType,
                _ => null,
            };
        }
    }
}