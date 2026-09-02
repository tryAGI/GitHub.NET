
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The data type of the issue field.
    /// </summary>
    public enum WebhookIssuesFieldAddedIssueFieldFieldType
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
    public static class WebhookIssuesFieldAddedIssueFieldFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesFieldAddedIssueFieldFieldType value)
        {
            return value switch
            {
                WebhookIssuesFieldAddedIssueFieldFieldType.Date => "date",
                WebhookIssuesFieldAddedIssueFieldFieldType.MultiSelect => "multi_select",
                WebhookIssuesFieldAddedIssueFieldFieldType.Number => "number",
                WebhookIssuesFieldAddedIssueFieldFieldType.SingleSelect => "single_select",
                WebhookIssuesFieldAddedIssueFieldFieldType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesFieldAddedIssueFieldFieldType? ToEnum(string value)
        {
            return value switch
            {
                "date" => WebhookIssuesFieldAddedIssueFieldFieldType.Date,
                "multi_select" => WebhookIssuesFieldAddedIssueFieldFieldType.MultiSelect,
                "number" => WebhookIssuesFieldAddedIssueFieldFieldType.Number,
                "single_select" => WebhookIssuesFieldAddedIssueFieldFieldType.SingleSelect,
                "text" => WebhookIssuesFieldAddedIssueFieldFieldType.Text,
                _ => null,
            };
        }
    }
}