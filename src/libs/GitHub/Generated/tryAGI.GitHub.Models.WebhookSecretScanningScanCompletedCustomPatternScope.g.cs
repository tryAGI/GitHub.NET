
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// If the scan was triggered by a custom pattern update, this will be the scope of the pattern that was updated
    /// </summary>
    public enum WebhookSecretScanningScanCompletedCustomPatternScope
    {
        /// <summary>
        ///
        /// </summary>
        Enterprise,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningScanCompletedCustomPatternScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningScanCompletedCustomPatternScope value)
        {
            return value switch
            {
                WebhookSecretScanningScanCompletedCustomPatternScope.Enterprise => "enterprise",
                WebhookSecretScanningScanCompletedCustomPatternScope.Organization => "organization",
                WebhookSecretScanningScanCompletedCustomPatternScope.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningScanCompletedCustomPatternScope? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => WebhookSecretScanningScanCompletedCustomPatternScope.Enterprise,
                "organization" => WebhookSecretScanningScanCompletedCustomPatternScope.Organization,
                "repository" => WebhookSecretScanningScanCompletedCustomPatternScope.Repository,
                _ => null,
            };
        }
    }
}