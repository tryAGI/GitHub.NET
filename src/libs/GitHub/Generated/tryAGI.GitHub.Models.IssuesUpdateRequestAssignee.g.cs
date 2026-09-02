
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesUpdateRequestAssignee
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        public string? Login { get; set; }

        /// <summary>
        /// Optional reasoning for selecting this assignee.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        /// If `true`, the change is stored as a pending suggestion for human review rather than applied directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggest")]
        public bool? Suggest { get; set; }

        /// <summary>
        /// The confidence level for this assignee choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateRequestAssigneeConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateRequestAssigneeConfidence? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequestAssignee" /> class.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="rationale">
        /// Optional reasoning for selecting this assignee.
        /// </param>
        /// <param name="suggest">
        /// If `true`, the change is stored as a pending suggestion for human review rather than applied directly.
        /// </param>
        /// <param name="confidence">
        /// The confidence level for this assignee choice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateRequestAssignee(
            string? login,
            string? rationale,
            bool? suggest,
            global::tryAGI.GitHub.IssuesUpdateRequestAssigneeConfidence? confidence)
        {
            this.Login = login;
            this.Rationale = rationale;
            this.Suggest = suggest;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateRequestAssignee" /> class.
        /// </summary>
        public IssuesUpdateRequestAssignee()
        {
        }

    }
}