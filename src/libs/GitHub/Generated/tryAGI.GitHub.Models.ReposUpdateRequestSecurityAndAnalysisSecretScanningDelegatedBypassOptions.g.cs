
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Feature options for secret scanning delegated bypass.<br/>
    /// This object is only honored when `security_and_analysis.secret_scanning_delegated_bypass.status` is set to `enabled`.<br/>
    /// You can send this object in the same request as `secret_scanning_delegated_bypass`, or update just the options in a separate request.
    /// </summary>
    public sealed partial class ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptions
    {
        /// <summary>
        /// The bypass reviewers for secret scanning delegated bypass.<br/>
        /// If you omit this field, the existing set of reviewers is unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewers")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewer>? Reviewers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptions" /> class.
        /// </summary>
        /// <param name="reviewers">
        /// The bypass reviewers for secret scanning delegated bypass.<br/>
        /// If you omit this field, the existing set of reviewers is unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptions(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptionsReviewer>? reviewers)
        {
            this.Reviewers = reviewers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptions" /> class.
        /// </summary>
        public ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptions()
        {
        }

    }
}