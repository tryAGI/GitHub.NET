
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFromJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevel" /> class.
        /// </summary>
        /// <param name="from"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevel(
            global::tryAGI.GitHub.WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevelFrom from)
        {
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevel" /> class.
        /// </summary>
        public WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevel()
        {
        }

    }
}