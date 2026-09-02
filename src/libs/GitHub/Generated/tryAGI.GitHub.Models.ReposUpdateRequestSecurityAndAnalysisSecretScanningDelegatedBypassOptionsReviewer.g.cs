
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewer
    {
        /// <summary>
        /// The ID of the team or role selected as a bypass reviewer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReviewerId { get; set; }

        /// <summary>
        /// The type of the bypass reviewer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType ReviewerType { get; set; }

        /// <summary>
        /// The bypass mode for the reviewer<br/>
        /// Default Value: ALWAYS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerModeJsonConverter))]
        public global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewer" /> class.
        /// </summary>
        /// <param name="reviewerId">
        /// The ID of the team or role selected as a bypass reviewer
        /// </param>
        /// <param name="reviewerType">
        /// The type of the bypass reviewer
        /// </param>
        /// <param name="mode">
        /// The bypass mode for the reviewer<br/>
        /// Default Value: ALWAYS
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewer(
            int reviewerId,
            global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerReviewerType reviewerType,
            global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewerMode? mode)
        {
            this.ReviewerId = reviewerId;
            this.ReviewerType = reviewerType;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewer" /> class.
        /// </summary>
        public ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewer()
        {
        }

    }
}