
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesAddIssueFieldValuesRequest
    {
        /// <summary>
        /// An array of issue field values to add to this issue. Each field value must include the field ID and the value to set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_field_values")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesAddIssueFieldValuesRequestIssueFieldValue>? IssueFieldValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddIssueFieldValuesRequest" /> class.
        /// </summary>
        /// <param name="issueFieldValues">
        /// An array of issue field values to add to this issue. Each field value must include the field ID and the value to set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesAddIssueFieldValuesRequest(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesAddIssueFieldValuesRequestIssueFieldValue>? issueFieldValues)
        {
            this.IssueFieldValues = issueFieldValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddIssueFieldValuesRequest" /> class.
        /// </summary>
        public IssuesAddIssueFieldValuesRequest()
        {
        }

    }
}