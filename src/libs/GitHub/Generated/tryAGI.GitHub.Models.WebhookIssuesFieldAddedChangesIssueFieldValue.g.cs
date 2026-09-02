
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The previous issue field value data.
    /// </summary>
    public sealed partial class WebhookIssuesFieldAddedChangesIssueFieldValue
    {
        /// <summary>
        /// The previous value of the issue field before the update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookIssuesFieldAddedChangesIssueFieldValueFrom From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldAddedChangesIssueFieldValue" /> class.
        /// </summary>
        /// <param name="from">
        /// The previous value of the issue field before the update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssuesFieldAddedChangesIssueFieldValue(
            global::tryAGI.GitHub.WebhookIssuesFieldAddedChangesIssueFieldValueFrom from)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldAddedChangesIssueFieldValue" /> class.
        /// </summary>
        public WebhookIssuesFieldAddedChangesIssueFieldValue()
        {
        }

    }
}