
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The suggestion's lifecycle state.
    /// </summary>
    public enum IssueSuggestionState
    {
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
    public static class IssueSuggestionStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueSuggestionState value)
        {
            return value switch
            {
                IssueSuggestionState.Applied => "applied",
                IssueSuggestionState.Approved => "approved",
                IssueSuggestionState.Dismissed => "dismissed",
                IssueSuggestionState.Invalidated => "invalidated",
                IssueSuggestionState.Pending => "pending",
                IssueSuggestionState.Replaced => "replaced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueSuggestionState? ToEnum(string value)
        {
            return value switch
            {
                "applied" => IssueSuggestionState.Applied,
                "approved" => IssueSuggestionState.Approved,
                "dismissed" => IssueSuggestionState.Dismissed,
                "invalidated" => IssueSuggestionState.Invalidated,
                "pending" => IssueSuggestionState.Pending,
                "replaced" => IssueSuggestionState.Replaced,
                _ => null,
            };
        }
    }
}