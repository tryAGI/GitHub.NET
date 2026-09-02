
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A custom pattern for secret scanning.
    /// </summary>
    public sealed partial class SecretScanningCustomPattern
    {
        /// <summary>
        /// The ID of the custom pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the custom pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The regular expression of the custom pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// A URL-friendly identifier for the custom pattern, derived from its name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The state of the custom pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.SecretScanningCustomPatternStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SecretScanningCustomPatternState State { get; set; }

        /// <summary>
        /// Whether push protection is enabled for this custom pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_protection_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PushProtectionEnabled { get; set; }

        /// <summary>
        /// The start delimiter regex for the custom pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_delimiter")]
        public string? StartDelimiter { get; set; }

        /// <summary>
        /// The end delimiter regex for the custom pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_delimiter")]
        public string? EndDelimiter { get; set; }

        /// <summary>
        /// List of regexes that the secret must match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("must_match")]
        public global::System.Collections.Generic.IList<string>? MustMatch { get; set; }

        /// <summary>
        /// List of regexes that the secret must not match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("must_not_match")]
        public global::System.Collections.Generic.IList<string>? MustNotMatch { get; set; }

        /// <summary>
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_pattern_version")]
        public string? CustomPatternVersion { get; set; }

        /// <summary>
        /// The date and time the custom pattern was created in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time the custom pattern was last updated in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningCustomPattern" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the custom pattern.
        /// </param>
        /// <param name="name">
        /// The name of the custom pattern.
        /// </param>
        /// <param name="pattern">
        /// The regular expression of the custom pattern.
        /// </param>
        /// <param name="slug">
        /// A URL-friendly identifier for the custom pattern, derived from its name.
        /// </param>
        /// <param name="state">
        /// The state of the custom pattern.
        /// </param>
        /// <param name="pushProtectionEnabled">
        /// Whether push protection is enabled for this custom pattern.
        /// </param>
        /// <param name="startDelimiter">
        /// The start delimiter regex for the custom pattern.
        /// </param>
        /// <param name="endDelimiter">
        /// The end delimiter regex for the custom pattern.
        /// </param>
        /// <param name="mustMatch">
        /// List of regexes that the secret must match.
        /// </param>
        /// <param name="mustNotMatch">
        /// List of regexes that the secret must not match.
        /// </param>
        /// <param name="customPatternVersion">
        /// The version of the entity. This is used to confirm you're updating the current version of the entity and mitigate unintentionally overriding someone else's update.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the custom pattern was created in ISO 8601 format.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the custom pattern was last updated in ISO 8601 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningCustomPattern(
            int id,
            string name,
            string pattern,
            string slug,
            global::tryAGI.GitHub.SecretScanningCustomPatternState state,
            bool pushProtectionEnabled,
            string? startDelimiter,
            string? endDelimiter,
            global::System.Collections.Generic.IList<string>? mustMatch,
            global::System.Collections.Generic.IList<string>? mustNotMatch,
            string? customPatternVersion,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.State = state;
            this.PushProtectionEnabled = pushProtectionEnabled;
            this.StartDelimiter = startDelimiter;
            this.EndDelimiter = endDelimiter;
            this.MustMatch = mustMatch;
            this.MustNotMatch = mustNotMatch;
            this.CustomPatternVersion = customPatternVersion;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningCustomPattern" /> class.
        /// </summary>
        public SecretScanningCustomPattern()
        {
        }

    }
}