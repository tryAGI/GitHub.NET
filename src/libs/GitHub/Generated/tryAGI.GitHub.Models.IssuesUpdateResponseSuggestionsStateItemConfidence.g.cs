
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesUpdateResponseSuggestionsStateItemConfidence
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
    public static class IssuesUpdateResponseSuggestionsStateItemConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateResponseSuggestionsStateItemConfidence value)
        {
            return value switch
            {
                IssuesUpdateResponseSuggestionsStateItemConfidence.High => "high",
                IssuesUpdateResponseSuggestionsStateItemConfidence.Low => "low",
                IssuesUpdateResponseSuggestionsStateItemConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateResponseSuggestionsStateItemConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesUpdateResponseSuggestionsStateItemConfidence.High,
                "low" => IssuesUpdateResponseSuggestionsStateItemConfidence.Low,
                "medium" => IssuesUpdateResponseSuggestionsStateItemConfidence.Medium,
                _ => null,
            };
        }
    }
}