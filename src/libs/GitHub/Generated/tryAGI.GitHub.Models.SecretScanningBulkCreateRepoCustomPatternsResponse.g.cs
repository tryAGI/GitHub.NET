
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretScanningBulkCreateRepoCustomPatternsResponse
    {
        /// <summary>
        /// The list of successfully created custom patterns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_patterns")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPattern>? CreatedPatterns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningBulkCreateRepoCustomPatternsResponse" /> class.
        /// </summary>
        /// <param name="createdPatterns">
        /// The list of successfully created custom patterns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningBulkCreateRepoCustomPatternsResponse(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPattern>? createdPatterns)
        {
            this.CreatedPatterns = createdPatterns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningBulkCreateRepoCustomPatternsResponse" /> class.
        /// </summary>
        public SecretScanningBulkCreateRepoCustomPatternsResponse()
        {
        }

    }
}