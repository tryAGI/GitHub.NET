
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretScanningBulkCreateOrgCustomPatternsRequest
    {
        /// <summary>
        /// The list of custom patterns to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patterns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPatternToCreate> Patterns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningBulkCreateOrgCustomPatternsRequest" /> class.
        /// </summary>
        /// <param name="patterns">
        /// The list of custom patterns to create.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningBulkCreateOrgCustomPatternsRequest(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPatternToCreate> patterns)
        {
            this.Patterns = patterns ?? throw new global::System.ArgumentNullException(nameof(patterns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningBulkCreateOrgCustomPatternsRequest" /> class.
        /// </summary>
        public SecretScanningBulkCreateOrgCustomPatternsRequest()
        {
        }

    }
}