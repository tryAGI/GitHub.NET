
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The confidence level for this label choice.
    /// </summary>
    public enum IssuesUpdateRequestLabelConfidence
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
    public static class IssuesUpdateRequestLabelConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateRequestLabelConfidence value)
        {
            return value switch
            {
                IssuesUpdateRequestLabelConfidence.High => "high",
                IssuesUpdateRequestLabelConfidence.Low => "low",
                IssuesUpdateRequestLabelConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateRequestLabelConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesUpdateRequestLabelConfidence.High,
                "low" => IssuesUpdateRequestLabelConfidence.Low,
                "medium" => IssuesUpdateRequestLabelConfidence.Medium,
                _ => null,
            };
        }
    }
}