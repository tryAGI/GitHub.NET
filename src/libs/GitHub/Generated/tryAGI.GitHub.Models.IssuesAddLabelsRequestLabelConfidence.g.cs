
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The confidence level for this label choice.
    /// </summary>
    public enum IssuesAddLabelsRequestLabelConfidence
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
    public static class IssuesAddLabelsRequestLabelConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesAddLabelsRequestLabelConfidence value)
        {
            return value switch
            {
                IssuesAddLabelsRequestLabelConfidence.High => "high",
                IssuesAddLabelsRequestLabelConfidence.Low => "low",
                IssuesAddLabelsRequestLabelConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesAddLabelsRequestLabelConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesAddLabelsRequestLabelConfidence.High,
                "low" => IssuesAddLabelsRequestLabelConfidence.Low,
                "medium" => IssuesAddLabelsRequestLabelConfidence.Medium,
                _ => null,
            };
        }
    }
}