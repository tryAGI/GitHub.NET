
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesUpdateRequest
    {
        /// <summary>
        /// The title of the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<string, int?>))]
        public global::tryAGI.GitHub.OneOf<string, int?>? Title { get; set; }

        /// <summary>
        /// The contents of the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Username to assign to this issue. **This field is closing down.**
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public string? Assignee { get; set; }

        /// <summary>
        /// The open or closed state of the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateRequestStateJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateRequestState? State { get; set; }

        /// <summary>
        /// The reason for the state change. Ignored unless `state` is changed.<br/>
        /// Example: not_planned
        /// </summary>
        /// <example>not_planned</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateRequestStateReasonJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateRequestStateReason? StateReason { get; set; }

        /// <summary>
        /// The ID of the issue to mark as the canonical duplicate when `state_reason` is `duplicate`. The issue must exist and be accessible to the authenticated user. Ignored when `state_reason` is not `duplicate`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duplicate_issue_id")]
        public int? DuplicateIssueId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<string, int?>))]
        public global::tryAGI.GitHub.OneOf<string, int?>? Milestone { get; set; }

        /// <summary>
        /// Labels to associate with this issue. Pass one or more labels to _replace_ the set of labels on this issue. Send an empty array (`[]`) to clear all labels from the issue. Only users with push access can set labels for issues. Without push access to the repository, label changes are silently dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<string, global::tryAGI.GitHub.IssuesUpdateRequestLabel>>? Labels { get; set; }

        /// <summary>
        /// Usernames to assign to this issue. Pass one or more user logins to _replace_ the set of assignees on this issue. Send an empty array (`[]`) to clear all assignees from the issue. Only users with push access can set assignees for new issues. Without push access to the repository, assignee changes are silently dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<string, global::tryAGI.GitHub.IssuesUpdateRequestAssignee>>? Assignees { get; set; }

        /// <summary>
        /// An array of issue field values to set on this issue. Each field value must include the field ID and the value to set. Only users with push access can set field values for issues
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_field_values")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateRequestIssueFieldValue>? IssueFieldValues { get; set; }

        /// <summary>
        /// The issue type to associate with this issue. Only users with push access can set the type for issues. Without push access to the repository, type changes are silently dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<string, global::tryAGI.GitHub.IssuesUpdateRequestType>))]
        public global::tryAGI.GitHub.OneOf<string, global::tryAGI.GitHub.IssuesUpdateRequestType>? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the issue.
        /// </param>
        /// <param name="body">
        /// The contents of the issue.
        /// </param>
        /// <param name="assignee">
        /// Username to assign to this issue. **This field is closing down.**
        /// </param>
        /// <param name="state">
        /// The open or closed state of the issue.
        /// </param>
        /// <param name="stateReason">
        /// The reason for the state change. Ignored unless `state` is changed.<br/>
        /// Example: not_planned
        /// </param>
        /// <param name="duplicateIssueId">
        /// The ID of the issue to mark as the canonical duplicate when `state_reason` is `duplicate`. The issue must exist and be accessible to the authenticated user. Ignored when `state_reason` is not `duplicate`.
        /// </param>
        /// <param name="milestone"></param>
        /// <param name="labels">
        /// Labels to associate with this issue. Pass one or more labels to _replace_ the set of labels on this issue. Send an empty array (`[]`) to clear all labels from the issue. Only users with push access can set labels for issues. Without push access to the repository, label changes are silently dropped.
        /// </param>
        /// <param name="assignees">
        /// Usernames to assign to this issue. Pass one or more user logins to _replace_ the set of assignees on this issue. Send an empty array (`[]`) to clear all assignees from the issue. Only users with push access can set assignees for new issues. Without push access to the repository, assignee changes are silently dropped.
        /// </param>
        /// <param name="issueFieldValues">
        /// An array of issue field values to set on this issue. Each field value must include the field ID and the value to set. Only users with push access can set field values for issues
        /// </param>
        /// <param name="type">
        /// The issue type to associate with this issue. Only users with push access can set the type for issues. Without push access to the repository, type changes are silently dropped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateRequest(
            global::tryAGI.GitHub.OneOf<string, int?>? title,
            string? body,
            string? assignee,
            global::tryAGI.GitHub.IssuesUpdateRequestState? state,
            global::tryAGI.GitHub.IssuesUpdateRequestStateReason? stateReason,
            int? duplicateIssueId,
            global::tryAGI.GitHub.OneOf<string, int?>? milestone,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<string, global::tryAGI.GitHub.IssuesUpdateRequestLabel>>? labels,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<string, global::tryAGI.GitHub.IssuesUpdateRequestAssignee>>? assignees,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesUpdateRequestIssueFieldValue>? issueFieldValues,
            global::tryAGI.GitHub.OneOf<string, global::tryAGI.GitHub.IssuesUpdateRequestType>? type)
        {
            this.Title = title;
            this.Body = body;
            this.Assignee = assignee;
            this.State = state;
            this.StateReason = stateReason;
            this.DuplicateIssueId = duplicateIssueId;
            this.Milestone = milestone;
            this.Labels = labels;
            this.Assignees = assignees;
            this.IssueFieldValues = issueFieldValues;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequest" /> class.
        /// </summary>
        public IssuesUpdateRequest()
        {
        }

    }
}