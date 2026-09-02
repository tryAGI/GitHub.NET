
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookIssuesFieldAddedAction
    {
        /// <summary>
        ///
        /// </summary>
        FieldAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesFieldAddedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesFieldAddedAction value)
        {
            return value switch
            {
                WebhookIssuesFieldAddedAction.FieldAdded => "field_added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesFieldAddedAction? ToEnum(string value)
        {
            return value switch
            {
                "field_added" => WebhookIssuesFieldAddedAction.FieldAdded,
                _ => null,
            };
        }
    }
}