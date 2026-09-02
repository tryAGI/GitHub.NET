
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesUpdateResponseSuggestionsAssigneeConfidence
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
    public static class IssuesUpdateResponseSuggestionsAssigneeConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateResponseSuggestionsAssigneeConfidence value)
        {
            return value switch
            {
                IssuesUpdateResponseSuggestionsAssigneeConfidence.High => "high",
                IssuesUpdateResponseSuggestionsAssigneeConfidence.Low => "low",
                IssuesUpdateResponseSuggestionsAssigneeConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateResponseSuggestionsAssigneeConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesUpdateResponseSuggestionsAssigneeConfidence.High,
                "low" => IssuesUpdateResponseSuggestionsAssigneeConfidence.Low,
                "medium" => IssuesUpdateResponseSuggestionsAssigneeConfidence.Medium,
                _ => null,
            };
        }
    }
}