
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesAddAssigneesRequestAssignee
    {
        /// <summary>
        /// The login of the user to assign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// Optional reasoning for adding this assignee.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        /// If `true`, the assignee is stored as a pending suggestion for human review rather than applied directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggest")]
        public bool? Suggest { get; set; }

        /// <summary>
        /// The confidence level for this assignee choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesAddAssigneesRequestAssigneeConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssuesAddAssigneesRequestAssigneeConfidence? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddAssigneesRequestAssignee" /> class.
        /// </summary>
        /// <param name="login">
        /// The login of the user to assign.
        /// </param>
        /// <param name="rationale">
        /// Optional reasoning for adding this assignee.
        /// </param>
        /// <param name="suggest">
        /// If `true`, the assignee is stored as a pending suggestion for human review rather than applied directly.
        /// </param>
        /// <param name="confidence">
        /// The confidence level for this assignee choice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesAddAssigneesRequestAssignee(
            string login,
            string? rationale,
            bool? suggest,
            global::tryAGI.GitHub.IssuesAddAssigneesRequestAssigneeConfidence? confidence)
        {
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Rationale = rationale;
            this.Suggest = suggest;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddAssigneesRequestAssignee" /> class.
        /// </summary>
        public IssuesAddAssigneesRequestAssignee()
        {
        }

    }
}