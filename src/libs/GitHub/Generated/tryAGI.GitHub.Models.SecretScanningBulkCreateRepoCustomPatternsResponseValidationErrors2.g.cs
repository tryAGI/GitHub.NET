
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretScanningBulkCreateRepoCustomPatternsResponseValidationErrors2
    {
        /// <summary>
        /// List of validation errors for this pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPatternValidationError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningBulkCreateRepoCustomPatternsResponseValidationErrors2" /> class.
        /// </summary>
        /// <param name="errors">
        /// List of validation errors for this pattern.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningBulkCreateRepoCustomPatternsResponseValidationErrors2(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPatternValidationError>? errors)
        {
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningBulkCreateRepoCustomPatternsResponseValidationErrors2" /> class.
        /// </summary>
        public SecretScanningBulkCreateRepoCustomPatternsResponseValidationErrors2()
        {
        }

    }
}