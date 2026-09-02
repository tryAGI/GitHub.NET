
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChanges
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::tryAGI.GitHub.WebhookRepositoryRulesetEditedChangesName? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        public global::tryAGI.GitHub.WebhookRepositoryRulesetEditedChangesEnforcement? Enforcement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::tryAGI.GitHub.WebhookRepositoryRulesetEditedChangesConditions? Conditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::tryAGI.GitHub.WebhookRepositoryRulesetEditedChangesRules? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChanges" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="enforcement"></param>
        /// <param name="conditions"></param>
        /// <param name="rules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRepositoryRulesetEditedChanges(
            global::tryAGI.GitHub.WebhookRepositoryRulesetEditedChangesName? name,
            global::tryAGI.GitHub.WebhookRepositoryRulesetEditedChangesEnforcement? enforcement,
            global::tryAGI.GitHub.WebhookRepositoryRulesetEditedChangesConditions? conditions,
            global::tryAGI.GitHub.WebhookRepositoryRulesetEditedChangesRules? rules)
        {
            this.Name = name;
            this.Enforcement = enforcement;
            this.Conditions = conditions;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChanges" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChanges()
        {
        }

    }
}