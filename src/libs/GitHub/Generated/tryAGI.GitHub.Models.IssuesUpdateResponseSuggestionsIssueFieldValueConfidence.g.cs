
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesUpdateResponseSuggestionsIssueFieldValueConfidence
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
    public static class IssuesUpdateResponseSuggestionsIssueFieldValueConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateResponseSuggestionsIssueFieldValueConfidence value)
        {
            return value switch
            {
                IssuesUpdateResponseSuggestionsIssueFieldValueConfidence.High => "high",
                IssuesUpdateResponseSuggestionsIssueFieldValueConfidence.Low => "low",
                IssuesUpdateResponseSuggestionsIssueFieldValueConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateResponseSuggestionsIssueFieldValueConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesUpdateResponseSuggestionsIssueFieldValueConfidence.High,
                "low" => IssuesUpdateResponseSuggestionsIssueFieldValueConfidence.Low,
                "medium" => IssuesUpdateResponseSuggestionsIssueFieldValueConfidence.Medium,
                _ => null,
            };
        }
    }
}