
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesCreateRequest
    {
        /// <summary>
        /// The title of the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OneOf<string, int?> Title { get; set; }

        /// <summary>
        /// The contents of the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Login for the user that this issue should be assigned to. _NOTE: Only users with push access can set the assignee for new issues. The assignee is silently dropped otherwise. **This field is closing down.**_
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public string? Assignee { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<string, int?>))]
        public global::tryAGI.GitHub.OneOf<string, int?>? Milestone { get; set; }

        /// <summary>
        /// Labels to associate with this issue. _NOTE: Only users with push access can set labels for new issues. Labels are silently dropped otherwise._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<string, global::tryAGI.GitHub.IssuesCreateRequestLabel>>? Labels { get; set; }

        /// <summary>
        /// Logins for Users to assign to this issue. _NOTE: Only users with push access can set assignees for new issues. Assignees are silently dropped otherwise._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<string>? Assignees { get; set; }

        /// <summary>
        /// An array of issue field values to set on this issue. Each field value must include the field ID and the value to set. Issue fields are only available for organization-owned repositories with the feature enabled. Field values are silently dropped otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_field_values")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesCreateRequestIssueFieldValue>? IssueFieldValues { get; set; }

        /// <summary>
        /// The name of the issue type to associate with this issue. _NOTE: Only users with push access can set the type for new issues. The type is silently dropped otherwise._<br/>
        /// Example: Epic
        /// </summary>
        /// <example>Epic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The id of the parent issue to add this issue to as a sub-issue. _NOTE: Only users with triage access to both the parent issue's repository and this repository can set the parent issue._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_issue_id")]
        public int? ParentIssueId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesCreateRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the issue.
        /// </param>
        /// <param name="body">
        /// The contents of the issue.
        /// </param>
        /// <param name="assignee">
        /// Login for the user that this issue should be assigned to. _NOTE: Only users with push access can set the assignee for new issues. The assignee is silently dropped otherwise. **This field is closing down.**_
        /// </param>
        /// <param name="milestone"></param>
        /// <param name="labels">
        /// Labels to associate with this issue. _NOTE: Only users with push access can set labels for new issues. Labels are silently dropped otherwise._
        /// </param>
        /// <param name="assignees">
        /// Logins for Users to assign to this issue. _NOTE: Only users with push access can set assignees for new issues. Assignees are silently dropped otherwise._
        /// </param>
        /// <param name="issueFieldValues">
        /// An array of issue field values to set on this issue. Each field value must include the field ID and the value to set. Issue fields are only available for organization-owned repositories with the feature enabled. Field values are silently dropped otherwise.
        /// </param>
        /// <param name="type">
        /// The name of the issue type to associate with this issue. _NOTE: Only users with push access can set the type for new issues. The type is silently dropped otherwise._<br/>
        /// Example: Epic
        /// </param>
        /// <param name="parentIssueId">
        /// The id of the parent issue to add this issue to as a sub-issue. _NOTE: Only users with triage access to both the parent issue's repository and this repository can set the parent issue._
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesCreateRequest(
            global::tryAGI.GitHub.OneOf<string, int?> title,
            string? body,
            string? assignee,
            global::tryAGI.GitHub.OneOf<string, int?>? milestone,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.OneOf<string, global::tryAGI.GitHub.IssuesCreateRequestLabel>>? labels,
            global::System.Collections.Generic.IList<string>? assignees,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesCreateRequestIssueFieldValue>? issueFieldValues,
            string? type,
            int? parentIssueId)
        {
            this.Title = title;
            this.Body = body;
            this.Assignee = assignee;
            this.Milestone = milestone;
            this.Labels = labels;
            this.Assignees = assignees;
            this.IssueFieldValues = issueFieldValues;
            this.Type = type;
            this.ParentIssueId = parentIssueId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesCreateRequest" /> class.
        /// </summary>
        public IssuesCreateRequest()
        {
        }

    }
}