
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The actor's confidence level in the suggestion.
    /// </summary>
    public enum IssueSuggestionConfidence
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
    public static class IssueSuggestionConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueSuggestionConfidence value)
        {
            return value switch
            {
                IssueSuggestionConfidence.High => "HIGH",
                IssueSuggestionConfidence.Low => "LOW",
                IssueSuggestionConfidence.Medium => "MEDIUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueSuggestionConfidence? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => IssueSuggestionConfidence.High,
                "LOW" => IssueSuggestionConfidence.Low,
                "MEDIUM" => IssueSuggestionConfidence.Medium,
                _ => null,
            };
        }
    }
}