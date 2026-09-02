
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The confidence level for this label choice.
    /// </summary>
    public enum IssuesAddLabelsRequestItemConfidence
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
    public static class IssuesAddLabelsRequestItemConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesAddLabelsRequestItemConfidence value)
        {
            return value switch
            {
                IssuesAddLabelsRequestItemConfidence.High => "high",
                IssuesAddLabelsRequestItemConfidence.Low => "low",
                IssuesAddLabelsRequestItemConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesAddLabelsRequestItemConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesAddLabelsRequestItemConfidence.High,
                "low" => IssuesAddLabelsRequestItemConfidence.Low,
                "medium" => IssuesAddLabelsRequestItemConfidence.Medium,
                _ => null,
            };
        }
    }
}