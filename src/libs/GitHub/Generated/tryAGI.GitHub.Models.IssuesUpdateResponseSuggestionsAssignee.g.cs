
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesUpdateResponseSuggestionsAssignee
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        public string? Login { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public string? Rationale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggest")]
        public bool? Suggest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateResponseSuggestionsAssigneeConfidenceJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsAssigneeConfidence? Confidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored")]
        public bool? Ignored { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.IssuesUpdateResponseSuggestionsAssigneeIgnoredReasonJsonConverter))]
        public global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsAssigneeIgnoredReason? IgnoredReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestionsAssignee" /> class.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="rationale"></param>
        /// <param name="suggest"></param>
        /// <param name="confidence"></param>
        /// <param name="ignored"></param>
        /// <param name="ignoredReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateResponseSuggestionsAssignee(
            string? login,
            string? rationale,
            bool? suggest,
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsAssigneeConfidence? confidence,
            bool? ignored,
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestionsAssigneeIgnoredReason? ignoredReason)
        {
            this.Login = login;
            this.Rationale = rationale;
            this.Suggest = suggest;
            this.Confidence = confidence;
            this.Ignored = ignored;
            this.IgnoredReason = ignoredReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponseSuggestionsAssignee" /> class.
        /// </summary>
        public IssuesUpdateResponseSuggestionsAssignee()
        {
        }

    }
}