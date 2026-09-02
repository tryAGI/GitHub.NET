
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A custom pattern to delete in a bulk operation.
    /// </summary>
    public sealed partial class SecretScanningCustomPatternToDelete
    {
        /// <summary>
        /// The ID of the custom pattern to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PatternId { get; set; }

        /// <summary>
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_pattern_version")]
        public string? CustomPatternVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningCustomPatternToDelete" /> class.
        /// </summary>
        /// <param name="patternId">
        /// The ID of the custom pattern to delete.
        /// </param>
        /// <param name="customPatternVersion">
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningCustomPatternToDelete(
            int patternId,
            string? customPatternVersion)
        {
            this.PatternId = patternId;
            this.CustomPatternVersion = customPatternVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningCustomPatternToDelete" /> class.
        /// </summary>
        public SecretScanningCustomPatternToDelete()
        {
        }

    }
}