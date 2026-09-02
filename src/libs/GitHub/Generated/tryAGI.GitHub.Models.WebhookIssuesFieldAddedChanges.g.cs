
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The previous field value, present when an existing value was updated.
    /// </summary>
    public sealed partial class WebhookIssuesFieldAddedChanges
    {
        /// <summary>
        /// The previous issue field value data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_field_value")]
        public global::tryAGI.GitHub.WebhookIssuesFieldAddedChangesIssueFieldValue? IssueFieldValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldAddedChanges" /> class.
        /// </summary>
        /// <param name="issueFieldValue">
        /// The previous issue field value data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssuesFieldAddedChanges(
            global::tryAGI.GitHub.WebhookIssuesFieldAddedChangesIssueFieldValue? issueFieldValue)
        {
            this.IssueFieldValue = issueFieldValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldAddedChanges" /> class.
        /// </summary>
        public WebhookIssuesFieldAddedChanges()
        {
        }

    }
}