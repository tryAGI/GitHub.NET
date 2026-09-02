
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecurityAndAnalysisSecretScanningDelegatedAlertDismissal
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.SecurityAndAnalysisSecretScanningDelegatedAlertDismissalStatusJsonConverter))]
        public global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningDelegatedAlertDismissalStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanningDelegatedAlertDismissal" /> class.
        /// </summary>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityAndAnalysisSecretScanningDelegatedAlertDismissal(
            global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningDelegatedAlertDismissalStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanningDelegatedAlertDismissal" /> class.
        /// </summary>
        public SecurityAndAnalysisSecretScanningDelegatedAlertDismissal()
        {
        }

    }
}