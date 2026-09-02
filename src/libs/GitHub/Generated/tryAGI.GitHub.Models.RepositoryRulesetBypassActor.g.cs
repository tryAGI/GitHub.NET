
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// An actor that can bypass rules in a ruleset
    /// </summary>
    public sealed partial class RepositoryRulesetBypassActor
    {
        /// <summary>
        /// The ID of the actor that can bypass a ruleset. Required for `Integration`, `RepositoryRole`, `Team`, and `User` actor types. If `actor_type` is `OrganizationAdmin`, `actor_id` is ignored. If `actor_type` is `DeployKey`, this should be null. `OrganizationAdmin` is not applicable for personal repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_id")]
        public int? ActorId { get; set; }

        /// <summary>
        /// The type of actor that can bypass a ruleset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryRulesetBypassActorActorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.RepositoryRulesetBypassActorActorType ActorType { get; set; }

        /// <summary>
        /// When the specified actor can bypass the ruleset. `pull_request` means that an actor can only bypass rules on pull requests. `pull_request` is not applicable for the `DeployKey` actor type. Also, `pull_request` is only applicable to branch rulesets. When `bypass_mode` is `exempt`, rules will not be run for that actor and a bypass audit entry will not be created.<br/>
        /// Default Value: always
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypass_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryRulesetBypassActorBypassModeJsonConverter))]
        public global::tryAGI.GitHub.RepositoryRulesetBypassActorBypassMode? BypassMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetBypassActor" /> class.
        /// </summary>
        /// <param name="actorType">
        /// The type of actor that can bypass a ruleset.
        /// </param>
        /// <param name="actorId">
        /// The ID of the actor that can bypass a ruleset. Required for `Integration`, `RepositoryRole`, `Team`, and `User` actor types. If `actor_type` is `OrganizationAdmin`, `actor_id` is ignored. If `actor_type` is `DeployKey`, this should be null. `OrganizationAdmin` is not applicable for personal repositories.
        /// </param>
        /// <param name="bypassMode">
        /// When the specified actor can bypass the ruleset. `pull_request` means that an actor can only bypass rules on pull requests. `pull_request` is not applicable for the `DeployKey` actor type. Also, `pull_request` is only applicable to branch rulesets. When `bypass_mode` is `exempt`, rules will not be run for that actor and a bypass audit entry will not be created.<br/>
        /// Default Value: always
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRulesetBypassActor(
            global::tryAGI.GitHub.RepositoryRulesetBypassActorActorType actorType,
            int? actorId,
            global::tryAGI.GitHub.RepositoryRulesetBypassActorBypassMode? bypassMode)
        {
            this.ActorId = actorId;
            this.ActorType = actorType;
            this.BypassMode = bypassMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetBypassActor" /> class.
        /// </summary>
        public RepositoryRulesetBypassActor()
        {
        }

    }
}