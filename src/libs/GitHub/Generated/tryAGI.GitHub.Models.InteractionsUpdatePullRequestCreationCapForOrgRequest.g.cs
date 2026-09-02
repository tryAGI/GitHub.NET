
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InteractionsUpdatePullRequestCreationCapForOrgRequest
    {
        /// <summary>
        /// Whether the pull request creation cap is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The maximum number of open pull requests a user can have at one time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_open_pull_requests")]
        public int? MaxOpenPullRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionsUpdatePullRequestCreationCapForOrgRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the pull request creation cap is enabled
        /// </param>
        /// <param name="maxOpenPullRequests">
        /// The maximum number of open pull requests a user can have at one time
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InteractionsUpdatePullRequestCreationCapForOrgRequest(
            bool enabled,
            int? maxOpenPullRequests)
        {
            this.Enabled = enabled;
            this.MaxOpenPullRequests = maxOpenPullRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionsUpdatePullRequestCreationCapForOrgRequest" /> class.
        /// </summary>
        public InteractionsUpdatePullRequestCreationCapForOrgRequest()
        {
        }

    }
}