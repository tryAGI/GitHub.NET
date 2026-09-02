
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The kind of change proposed.
    /// </summary>
    public enum IssueSuggestionAction
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
    public static class IssueSuggestionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueSuggestionAction value)
        {
            return value switch
            {
                IssueSuggestionAction.AddAssignee => "add_assignee",
                IssueSuggestionAction.AddField => "add_field",
                IssueSuggestionAction.AddLabel => "add_label",
                IssueSuggestionAction.CloseIssue => "close_issue",
                IssueSuggestionAction.SetType => "set_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueSuggestionAction? ToEnum(string value)
        {
            return value switch
            {
                "add_assignee" => IssueSuggestionAction.AddAssignee,
                "add_field" => IssueSuggestionAction.AddField,
                "add_label" => IssueSuggestionAction.AddLabel,
                "close_issue" => IssueSuggestionAction.CloseIssue,
                "set_type" => IssueSuggestionAction.SetType,
                _ => null,
            };
        }
    }
}