
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A validation error for a custom pattern in a batch operation.
    /// </summary>
    public sealed partial class SecretScanningCustomPatternValidationError
    {
        /// <summary>
        /// A machine-readable code describing the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.SecretScanningCustomPatternValidationErrorCodeJsonConverter))]
        public global::tryAGI.GitHub.SecretScanningCustomPatternValidationErrorCode? Code { get; set; }

        /// <summary>
        /// A human-readable description of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningCustomPatternValidationError" /> class.
        /// </summary>
        /// <param name="code">
        /// A machine-readable code describing the error.
        /// </param>
        /// <param name="message">
        /// A human-readable description of the error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningCustomPatternValidationError(
            global::tryAGI.GitHub.SecretScanningCustomPatternValidationErrorCode? code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningCustomPatternValidationError" /> class.
        /// </summary>
        public SecretScanningCustomPatternValidationError()
        {
        }

    }
}