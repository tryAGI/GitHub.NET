
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Only allow users with bypass permission to create matching refs.
    /// </summary>
    public sealed partial class RepositoryRuleCreation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryRuleCreationTypeJsonConverter))]
        public global::tryAGI.GitHub.RepositoryRuleCreationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCreation" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleCreation(
            global::tryAGI.GitHub.RepositoryRuleCreationType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCreation" /> class.
        /// </summary>
        public RepositoryRuleCreation()
        {
        }

    }
}