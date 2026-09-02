
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Prevent merge commits from being pushed to matching refs.
    /// </summary>
    public sealed partial class RepositoryRuleRequiredLinearHistory
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryRuleRequiredLinearHistoryTypeJsonConverter))]
        public global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistoryType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredLinearHistory" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleRequiredLinearHistory(
            global::tryAGI.GitHub.RepositoryRuleRequiredLinearHistoryType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredLinearHistory" /> class.
        /// </summary>
        public RepositoryRuleRequiredLinearHistory()
        {
        }

    }
}