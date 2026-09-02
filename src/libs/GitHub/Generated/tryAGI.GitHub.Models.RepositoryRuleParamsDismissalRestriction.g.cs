
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Specify people, teams, or apps allowed to dismiss pull request reviews.
    /// </summary>
    public sealed partial class RepositoryRuleParamsDismissalRestriction
    {
        /// <summary>
        /// Specify people, teams, or apps allowed to dismiss pull request reviews.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_actors")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.RepositoryRuleParamsActor>? AllowedActors { get; set; }

        /// <summary>
        /// Whether to restrict review dismissal to specific actors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsDismissalRestriction" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether to restrict review dismissal to specific actors.
        /// </param>
        /// <param name="allowedActors">
        /// Specify people, teams, or apps allowed to dismiss pull request reviews.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleParamsDismissalRestriction(
            bool enabled,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.RepositoryRuleParamsActor>? allowedActors)
        {
            this.AllowedActors = allowedActors;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsDismissalRestriction" /> class.
        /// </summary>
        public RepositoryRuleParamsDismissalRestriction()
        {
        }

    }
}