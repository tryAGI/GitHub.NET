
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The confidence level for this field value choice.
    /// </summary>
    public enum IssuesUpdateRequestIssueFieldValueConfidence
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
    public static class IssuesUpdateRequestIssueFieldValueConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateRequestIssueFieldValueConfidence value)
        {
            return value switch
            {
                IssuesUpdateRequestIssueFieldValueConfidence.High => "high",
                IssuesUpdateRequestIssueFieldValueConfidence.Low => "low",
                IssuesUpdateRequestIssueFieldValueConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateRequestIssueFieldValueConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesUpdateRequestIssueFieldValueConfidence.High,
                "low" => IssuesUpdateRequestIssueFieldValueConfidence.Low,
                "medium" => IssuesUpdateRequestIssueFieldValueConfidence.Medium,
                _ => null,
            };
        }
    }
}