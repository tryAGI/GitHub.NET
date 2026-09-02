
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The confidence level for this assignee choice.
    /// </summary>
    public enum IssuesAddAssigneesRequestAssigneeConfidence
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
    public static class IssuesAddAssigneesRequestAssigneeConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesAddAssigneesRequestAssigneeConfidence value)
        {
            return value switch
            {
                IssuesAddAssigneesRequestAssigneeConfidence.High => "high",
                IssuesAddAssigneesRequestAssigneeConfidence.Low => "low",
                IssuesAddAssigneesRequestAssigneeConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesAddAssigneesRequestAssigneeConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesAddAssigneesRequestAssigneeConfidence.High,
                "low" => IssuesAddAssigneesRequestAssigneeConfidence.Low,
                "medium" => IssuesAddAssigneesRequestAssigneeConfidence.Medium,
                _ => null,
            };
        }
    }
}