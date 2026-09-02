
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: pending
    /// </summary>
    public enum IssuesListSuggestionsState
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Applied,
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        Dismissed,
        /// <summary>
        ///
        /// </summary>
        Invalidated,
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Replaced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListSuggestionsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListSuggestionsState value)
        {
            return value switch
            {
                IssuesListSuggestionsState.All => "all",
                IssuesListSuggestionsState.Applied => "applied",
                IssuesListSuggestionsState.Approved => "approved",
                IssuesListSuggestionsState.Dismissed => "dismissed",
                IssuesListSuggestionsState.Invalidated => "invalidated",
                IssuesListSuggestionsState.Pending => "pending",
                IssuesListSuggestionsState.Replaced => "replaced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListSuggestionsState? ToEnum(string value)
        {
            return value switch
            {
                "all" => IssuesListSuggestionsState.All,
                "applied" => IssuesListSuggestionsState.Applied,
                "approved" => IssuesListSuggestionsState.Approved,
                "dismissed" => IssuesListSuggestionsState.Dismissed,
                "invalidated" => IssuesListSuggestionsState.Invalidated,
                "pending" => IssuesListSuggestionsState.Pending,
                "replaced" => IssuesListSuggestionsState.Replaced,
                _ => null,
            };
        }
    }
}