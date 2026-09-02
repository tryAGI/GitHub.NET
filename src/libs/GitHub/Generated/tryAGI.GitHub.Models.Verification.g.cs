
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Verification
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public string? Payload { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

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
        /// Initializes a new instance of the <see cref="Verification" /> class.
        /// </summary>
        /// <param name="verified"></param>
        /// <param name="reason"></param>
        /// <param name="payload"></param>
        /// <param name="signature"></param>
        /// <param name="verifiedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Verification(
            bool verified,
            string reason,
            string? payload,
            string? signature,
            string? verifiedAt)
        {
            this.Verified = verified;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Payload = payload;
            this.Signature = signature;
            this.VerifiedAt = verifiedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Verification" /> class.
        /// </summary>
        public Verification()
        {
        }

    }
}