
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Prevent commits that include file paths that exceed the specified character limit from being pushed to the commit graph.
    /// </summary>
    public sealed partial class RepositoryRuleMaxFilePathLength
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryRuleMaxFilePathLengthTypeJsonConverter))]
        public global::tryAGI.GitHub.RepositoryRuleMaxFilePathLengthType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::tryAGI.GitHub.RepositoryRuleMaxFilePathLengthParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMaxFilePathLength" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleMaxFilePathLength(
            global::tryAGI.GitHub.RepositoryRuleMaxFilePathLengthType type,
            global::tryAGI.GitHub.RepositoryRuleMaxFilePathLengthParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMaxFilePathLength" /> class.
        /// </summary>
        public RepositoryRuleMaxFilePathLength()
        {
        }

    }
}