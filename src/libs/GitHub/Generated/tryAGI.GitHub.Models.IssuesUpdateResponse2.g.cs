
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesUpdateResponse2
    {
        /// <summary>
        /// Pending suggestions for each suggestible field (`type`,<br/>
        /// `issue_field_values`, `labels`, `assignees`, `state`) the<br/>
        /// request touched. Omitted for fields not in the request or<br/>
        /// with no pending or ignored suggestions. Items tagged<br/>
        /// `ignored` are echoes of the current request's inputs that<br/>
        /// were not persisted as pending suggestions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestions")]
        public global::tryAGI.GitHub.IssuesUpdateResponseSuggestions? Suggestions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponse2" /> class.
        /// </summary>
        /// <param name="suggestions">
        /// Pending suggestions for each suggestible field (`type`,<br/>
        /// `issue_field_values`, `labels`, `assignees`, `state`) the<br/>
        /// request touched. Omitted for fields not in the request or<br/>
        /// with no pending or ignored suggestions. Items tagged<br/>
        /// `ignored` are echoes of the current request's inputs that<br/>
        /// were not persisted as pending suggestions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesUpdateResponse2(
            global::tryAGI.GitHub.IssuesUpdateResponseSuggestions? suggestions)
        {
            this.Suggestions = suggestions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesUpdateResponse2" /> class.
        /// </summary>
        public IssuesUpdateResponse2()
        {
        }

    }
}