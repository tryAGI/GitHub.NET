
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Pending suggestions for each suggestible field (`type`,<br/>
    /// `issue_field_values`, `labels`, `assignees`, `state`) the<br/>
    /// request touched. Omitted for fields not in the request or<br/>
    /// with no pending or ignored suggestions. Items tagged<br/>
    /// `ignored` are echoes of the current request's inputs that<br/>
    /// were not persisted as pending suggestions.
    /// </summary>
    public sealed partial class IssuesUpdateResponseSuggestions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsTypeItem>? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_field_values")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValue>? IssueFieldValues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsLabel>? Labels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsAssignee>? Assignees { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsStateItem>? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestions" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="issueFieldValues"></param>
        /// <param name="labels"></param>
        /// <param name="assignees"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateResponseSuggestions(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsTypeItem>? type,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsIssueFieldValue>? issueFieldValues,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsLabel>? labels,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsAssignee>? assignees,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsStateItem>? state)
        {
            this.Type = type;
            this.IssueFieldValues = issueFieldValues;
            this.Labels = labels;
            this.Assignees = assignees;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestions" /> class.
        /// </summary>
        public IssuesUpdateResponseSuggestions()
        {
        }

    }
}