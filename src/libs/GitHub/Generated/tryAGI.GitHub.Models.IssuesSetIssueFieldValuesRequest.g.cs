
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesSetIssueFieldValuesRequest
    {
        /// <summary>
        /// An array of issue field values to set for this issue. Each field value must include the field ID and the value to set. All existing field values will be replaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_field_values")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesSetIssueFieldValuesRequestIssueFieldValue>? IssueFieldValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesSetIssueFieldValuesRequest" /> class.
        /// </summary>
        /// <param name="issueFieldValues">
        /// An array of issue field values to set for this issue. Each field value must include the field ID and the value to set. All existing field values will be replaced.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesSetIssueFieldValuesRequest(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesSetIssueFieldValuesRequestIssueFieldValue>? issueFieldValues)
        {
            this.IssueFieldValues = issueFieldValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesSetIssueFieldValuesRequest" /> class.
        /// </summary>
        public IssuesSetIssueFieldValuesRequest()
        {
        }

    }
}