
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookStatusCommitCommitVerification
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public string? Payload { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookStatusCommitCommitVerificationReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookStatusCommitCommitVerificationReason Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified_at")]
        public string? VerifiedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommitVerification" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="verified"></param>
        /// <param name="payload"></param>
        /// <param name="signature"></param>
        /// <param name="verifiedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookStatusCommitCommitVerification(
            global::tryAGI.GitHub.WebhookStatusCommitCommitVerificationReason reason,
            bool verified,
            string? payload,
            string? signature,
            string? verifiedAt)
        {
            this.Payload = payload;
            this.Reason = reason;
            this.Signature = signature;
            this.Verified = verified;
            this.VerifiedAt = verifiedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommitVerification" /> class.
        /// </summary>
        public WebhookStatusCommitCommitVerification()
        {
        }

    }
}