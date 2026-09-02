
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Fields to update on a custom pattern. At least one updatable field (`pattern`, `start_delimiter`, `end_delimiter`, `must_match`, or `must_not_match`) must also be provided. Only provided fields will be updated.
    /// </summary>
    public sealed partial class SecretScanningCustomPatternToUpdate
    {
        /// <summary>
        /// The updated regular expression of the custom pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// The updated start delimiter regex for the custom pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_delimiter")]
        public string? StartDelimiter { get; set; }

        /// <summary>
        /// The updated end delimiter regex for the custom pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_delimiter")]
        public string? EndDelimiter { get; set; }

        /// <summary>
        /// Updated list of regexes that the secret must match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("must_match")]
        public global::System.Collections.Generic.IList<string>? MustMatch { get; set; }

        /// <summary>
        /// Updated list of regexes that the secret must not match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("must_not_match")]
        public global::System.Collections.Generic.IList<string>? MustNotMatch { get; set; }

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
        /// Initializes a new instance of the <see cref="SecretScanningCustomPatternToUpdate" /> class.
        /// </summary>
        /// <param name="pattern">
        /// The updated regular expression of the custom pattern.
        /// </param>
        /// <param name="startDelimiter">
        /// The updated start delimiter regex for the custom pattern.
        /// </param>
        /// <param name="endDelimiter">
        /// The updated end delimiter regex for the custom pattern.
        /// </param>
        /// <param name="mustMatch">
        /// Updated list of regexes that the secret must match.
        /// </param>
        /// <param name="mustNotMatch">
        /// Updated list of regexes that the secret must not match.
        /// </param>
        /// <param name="customPatternVersion">
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningCustomPatternToUpdate(
            string? pattern,
            string? startDelimiter,
            string? endDelimiter,
            global::System.Collections.Generic.IList<string>? mustMatch,
            global::System.Collections.Generic.IList<string>? mustNotMatch,
            string? customPatternVersion)
        {
            this.Pattern = pattern;
            this.StartDelimiter = startDelimiter;
            this.EndDelimiter = endDelimiter;
            this.MustMatch = mustMatch;
            this.MustNotMatch = mustNotMatch;
            this.CustomPatternVersion = customPatternVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningCustomPatternToUpdate" /> class.
        /// </summary>
        public SecretScanningCustomPatternToUpdate()
        {
        }

    }
}