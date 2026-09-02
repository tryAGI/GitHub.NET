
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Branch Protection
    /// </summary>
    public sealed partial class BranchProtection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Protected Branch Required Status Check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks")]
        public global::tryAGI.GitHub.ProtectedBranchRequiredStatusCheck? RequiredStatusChecks { get; set; }

        /// <summary>
        /// Protected Branch Admin Enforced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_admins")]
        public global::tryAGI.GitHub.ProtectedBranchAdminEnforced? EnforceAdmins { get; set; }

        /// <summary>
        /// Protected Branch Pull Request Review
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_pull_request_reviews")]
        public global::tryAGI.GitHub.ProtectedBranchPullRequestReview? RequiredPullRequestReviews { get; set; }

        /// <summary>
        /// Branch Restriction Policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictions")]
        public global::tryAGI.GitHub.BranchRestrictionPolicy? Restrictions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_linear_history")]
        public global::tryAGI.GitHub.BranchProtectionRequiredLinearHistory? RequiredLinearHistory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_force_pushes")]
        public global::tryAGI.GitHub.BranchProtectionAllowForcePushes? AllowForcePushes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_deletions")]
        public global::tryAGI.GitHub.BranchProtectionAllowDeletions? AllowDeletions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_creations")]
        public global::tryAGI.GitHub.BranchProtectionBlockCreations? BlockCreations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_conversation_resolution")]
        public global::tryAGI.GitHub.BranchProtectionRequiredConversationResolution? RequiredConversationResolution { get; set; }

        /// <summary>
        /// Example: "branch/with/protection"
        /// </summary>
        /// <example>"branch/with/protection"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/repos/owner-79e94e2d36b3fd06a32bb213/AAA_Public_Repo/branches/branch/with/protection/protection"
        /// </summary>
        /// <example>"https://api.github.com/repos/owner-79e94e2d36b3fd06a32bb213/AAA_Public_Repo/branches/branch/with/protection/protection"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection_url")]
        public string? ProtectionUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_signatures")]
        public global::tryAGI.GitHub.BranchProtectionRequiredSignatures? RequiredSignatures { get; set; }

        /// <summary>
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_branch")]
        public global::tryAGI.GitHub.BranchProtectionLockBranch? LockBranch { get; set; }

        /// <summary>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_fork_syncing")]
        public global::tryAGI.GitHub.BranchProtectionAllowForkSyncing? AllowForkSyncing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtection" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="enabled"></param>
        /// <param name="requiredStatusChecks">
        /// Protected Branch Required Status Check
        /// </param>
        /// <param name="enforceAdmins">
        /// Protected Branch Admin Enforced
        /// </param>
        /// <param name="requiredPullRequestReviews">
        /// Protected Branch Pull Request Review
        /// </param>
        /// <param name="restrictions">
        /// Branch Restriction Policy
        /// </param>
        /// <param name="requiredLinearHistory"></param>
        /// <param name="allowForcePushes"></param>
        /// <param name="allowDeletions"></param>
        /// <param name="blockCreations"></param>
        /// <param name="requiredConversationResolution"></param>
        /// <param name="name">
        /// Example: "branch/with/protection"
        /// </param>
        /// <param name="protectionUrl">
        /// Example: "https://api.github.com/repos/owner-79e94e2d36b3fd06a32bb213/AAA_Public_Repo/branches/branch/with/protection/protection"
        /// </param>
        /// <param name="requiredSignatures"></param>
        /// <param name="lockBranch">
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        /// </param>
        /// <param name="allowForkSyncing">
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchProtection(
            string? url,
            bool? enabled,
            global::tryAGI.GitHub.ProtectedBranchRequiredStatusCheck? requiredStatusChecks,
            global::tryAGI.GitHub.ProtectedBranchAdminEnforced? enforceAdmins,
            global::tryAGI.GitHub.ProtectedBranchPullRequestReview? requiredPullRequestReviews,
            global::tryAGI.GitHub.BranchRestrictionPolicy? restrictions,
            global::tryAGI.GitHub.BranchProtectionRequiredLinearHistory? requiredLinearHistory,
            global::tryAGI.GitHub.BranchProtectionAllowForcePushes? allowForcePushes,
            global::tryAGI.GitHub.BranchProtectionAllowDeletions? allowDeletions,
            global::tryAGI.GitHub.BranchProtectionBlockCreations? blockCreations,
            global::tryAGI.GitHub.BranchProtectionRequiredConversationResolution? requiredConversationResolution,
            string? name,
            string? protectionUrl,
            global::tryAGI.GitHub.BranchProtectionRequiredSignatures? requiredSignatures,
            global::tryAGI.GitHub.BranchProtectionLockBranch? lockBranch,
            global::tryAGI.GitHub.BranchProtectionAllowForkSyncing? allowForkSyncing)
        {
            this.Url = url;
            this.Enabled = enabled;
            this.RequiredStatusChecks = requiredStatusChecks;
            this.EnforceAdmins = enforceAdmins;
            this.RequiredPullRequestReviews = requiredPullRequestReviews;
            this.Restrictions = restrictions;
            this.RequiredLinearHistory = requiredLinearHistory;
            this.AllowForcePushes = allowForcePushes;
            this.AllowDeletions = allowDeletions;
            this.BlockCreations = blockCreations;
            this.RequiredConversationResolution = requiredConversationResolution;
            this.Name = name;
            this.ProtectionUrl = protectionUrl;
            this.RequiredSignatures = requiredSignatures;
            this.LockBranch = lockBranch;
            this.AllowForkSyncing = allowForkSyncing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtection" /> class.
        /// </summary>
        public BranchProtection()
        {
        }

    }
}