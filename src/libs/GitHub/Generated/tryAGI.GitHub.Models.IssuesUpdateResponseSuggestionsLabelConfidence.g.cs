
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum IssuesUpdateResponseSuggestionsLabelConfidence
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
    public static class IssuesUpdateResponseSuggestionsLabelConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesUpdateResponseSuggestionsLabelConfidence value)
        {
            return value switch
            {
                IssuesUpdateResponseSuggestionsLabelConfidence.High => "high",
                IssuesUpdateResponseSuggestionsLabelConfidence.Low => "low",
                IssuesUpdateResponseSuggestionsLabelConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesUpdateResponseSuggestionsLabelConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => IssuesUpdateResponseSuggestionsLabelConfidence.High,
                "low" => IssuesUpdateResponseSuggestionsLabelConfidence.Low,
                "medium" => IssuesUpdateResponseSuggestionsLabelConfidence.Medium,
                _ => null,
            };
        }
    }
}