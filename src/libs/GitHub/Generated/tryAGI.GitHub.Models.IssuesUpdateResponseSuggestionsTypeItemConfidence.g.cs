
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesUpdateResponseSuggestionsTypeItemConfidence
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesUpdateResponseSuggestionsTypeItemConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateResponseSuggestionsTypeItemConfidence value)
        {
            return value switch
            {
                IssuesUpdateResponseSuggestionsTypeItemConfidence.High => "high",
                IssuesUpdateResponseSuggestionsTypeItemConfidence.Low => "low",
                IssuesUpdateResponseSuggestionsTypeItemConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateResponseSuggestionsTypeItemConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesUpdateResponseSuggestionsTypeItemConfidence.High,
                "low" => IssuesUpdateResponseSuggestionsTypeItemConfidence.Low,
                "medium" => IssuesUpdateResponseSuggestionsTypeItemConfidence.Medium,
                _ => null,
            };
        }
    }
}