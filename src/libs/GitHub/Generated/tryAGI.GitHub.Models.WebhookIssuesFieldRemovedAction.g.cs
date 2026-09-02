
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssuesFieldRemovedAction
    {
        /// <summary>
        ///
        /// </summary>
        FieldRemoved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesFieldRemovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesFieldRemovedAction value)
        {
            return value switch
            {
                WebhookIssuesFieldRemovedAction.FieldRemoved => "field_removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesFieldRemovedAction? ToEnum(string value)
        {
            return value switch
            {
                "field_removed" => WebhookIssuesFieldRemovedAction.FieldRemoved,
                _ => null,
            };
        }
    }
}