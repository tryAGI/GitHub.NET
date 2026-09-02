
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretScanningBulkCreateOrgCustomPatternsResponse2
    {
        /// <summary>
        /// A summary message describing the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// A map of validation errors keyed by the zero-based index of the pattern that failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_errors")]
        public global::System.Collections.Generic.Dictionary<string, global::tryAGI.GitHub.SecretScanningBulkCreateOrgCustomPatternsResponseValidationErrors2>? ValidationErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningBulkCreateOrgCustomPatternsResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// A summary message describing the error.
        /// </param>
        /// <param name="validationErrors">
        /// A map of validation errors keyed by the zero-based index of the pattern that failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningBulkCreateOrgCustomPatternsResponse2(
            string? message,
            global::System.Collections.Generic.Dictionary<string, global::tryAGI.GitHub.SecretScanningBulkCreateOrgCustomPatternsResponseValidationErrors2>? validationErrors)
        {
            this.Message = message;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningBulkCreateOrgCustomPatternsResponse2" /> class.
        /// </summary>
        public SecretScanningBulkCreateOrgCustomPatternsResponse2()
        {
        }

    }
}