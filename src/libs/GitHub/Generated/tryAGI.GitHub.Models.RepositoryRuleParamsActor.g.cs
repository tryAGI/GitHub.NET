
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// An actor allowed to dismiss pull request reviews
    /// </summary>
    public sealed partial class RepositoryRuleParamsActor
    {
        /// <summary>
        /// ID of the actor that can dismiss reviews.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The type of the actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryRuleParamsActorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.RepositoryRuleParamsActorType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsActor" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the actor that can dismiss reviews.
        /// </param>
        /// <param name="type">
        /// The type of the actor
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleParamsActor(
            int id,
            global::tryAGI.GitHub.RepositoryRuleParamsActorType type)
        {
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsActor" /> class.
        /// </summary>
        public RepositoryRuleParamsActor()
        {
        }

    }
}