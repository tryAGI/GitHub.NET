
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Parameters to be used for the commit_author_email_pattern rule
    /// </summary>
    public sealed partial class RepositoryRuleCommitAuthorEmailPattern
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryRuleCommitAuthorEmailPatternTypeJsonConverter))]
        public global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPatternType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitAuthorEmailPattern" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleCommitAuthorEmailPattern(
            global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPatternType type,
            global::tryAGI.GitHub.RepositoryRuleCommitAuthorEmailPatternParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitAuthorEmailPattern" /> class.
        /// </summary>
        public RepositoryRuleCommitAuthorEmailPattern()
        {
        }

    }
}