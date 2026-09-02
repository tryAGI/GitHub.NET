
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The confidence level for this type choice.
    /// </summary>
    public enum IssuesUpdateRequestTypeConfidence
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
    public static class IssuesUpdateRequestTypeConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateRequestTypeConfidence value)
        {
            return value switch
            {
                IssuesUpdateRequestTypeConfidence.High => "high",
                IssuesUpdateRequestTypeConfidence.Low => "low",
                IssuesUpdateRequestTypeConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateRequestTypeConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesUpdateRequestTypeConfidence.High,
                "low" => IssuesUpdateRequestTypeConfidence.Low,
                "medium" => IssuesUpdateRequestTypeConfidence.Medium,
                _ => null,
            };
        }
    }
}