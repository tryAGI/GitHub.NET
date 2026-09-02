
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The data type of the issue field.
    /// </summary>
    public enum WebhookIssuesFieldRemovedIssueFieldFieldType
    {
        /// <summary>
        ///
        /// </summary>
        Date,
        /// <summary>
        ///
        /// </summary>
        MultiSelect,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        SingleSelect,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesFieldRemovedIssueFieldFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesFieldRemovedIssueFieldFieldType value)
        {
            return value switch
            {
                WebhookIssuesFieldRemovedIssueFieldFieldType.Date => "date",
                WebhookIssuesFieldRemovedIssueFieldFieldType.MultiSelect => "multi_select",
                WebhookIssuesFieldRemovedIssueFieldFieldType.Number => "number",
                WebhookIssuesFieldRemovedIssueFieldFieldType.SingleSelect => "single_select",
                WebhookIssuesFieldRemovedIssueFieldFieldType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesFieldRemovedIssueFieldFieldType? ToEnum(string value)
        {
            return value switch
            {
                "date" => WebhookIssuesFieldRemovedIssueFieldFieldType.Date,
                "multi_select" => WebhookIssuesFieldRemovedIssueFieldFieldType.MultiSelect,
                "number" => WebhookIssuesFieldRemovedIssueFieldFieldType.Number,
                "single_select" => WebhookIssuesFieldRemovedIssueFieldFieldType.SingleSelect,
                "text" => WebhookIssuesFieldRemovedIssueFieldFieldType.Text,
                _ => null,
            };
        }
    }
}