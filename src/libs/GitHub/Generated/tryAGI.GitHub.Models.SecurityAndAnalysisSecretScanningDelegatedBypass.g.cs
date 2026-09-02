
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecurityAndAnalysisSecretScanningDelegatedBypass
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.SecurityAndAnalysisSecretScanningDelegatedBypassStatusJsonConverter))]
        public global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningDelegatedBypassStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanningDelegatedBypass" /> class.
        /// </summary>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityAndAnalysisSecretScanningDelegatedBypass(
            global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningDelegatedBypassStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysisSecretScanningDelegatedBypass" /> class.
        /// </summary>
        public SecurityAndAnalysisSecretScanningDelegatedBypass()
        {
        }

    }
}