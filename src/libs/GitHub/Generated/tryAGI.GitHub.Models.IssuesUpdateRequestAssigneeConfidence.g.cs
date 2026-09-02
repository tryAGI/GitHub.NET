
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The confidence level for this assignee choice.
    /// </summary>
    public enum IssuesUpdateRequestAssigneeConfidence
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
    public static class IssuesUpdateRequestAssigneeConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateRequestAssigneeConfidence value)
        {
            return value switch
            {
                IssuesUpdateRequestAssigneeConfidence.High => "high",
                IssuesUpdateRequestAssigneeConfidence.Low => "low",
                IssuesUpdateRequestAssigneeConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateRequestAssigneeConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesUpdateRequestAssigneeConfidence.High,
                "low" => IssuesUpdateRequestAssigneeConfidence.Low,
                "medium" => IssuesUpdateRequestAssigneeConfidence.Medium,
                _ => null,
            };
        }
    }
}