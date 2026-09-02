
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A custom pattern to create in a bulk operation.
    /// </summary>
    public sealed partial class SecretScanningCustomPatternToCreate
    {
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
        /// The start delimiter regex for the custom pattern.<br/>
        /// Defaults to `\A|[^0-9A-Za-z]` when not specified.<br/>
        /// Default Value: \A|[^0-9A-Za-z]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_delimiter")]
        public string? StartDelimiter { get; set; }

        /// <summary>
        /// The end delimiter regex for the custom pattern.<br/>
        /// Defaults to `\z|[^0-9A-Za-z]` when not specified.<br/>
        /// Default Value: \z|[^0-9A-Za-z]
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningCustomPatternToCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the custom pattern.
        /// </param>
        /// <param name="pattern">
        /// The regular expression of the custom pattern.
        /// </param>
        /// <param name="startDelimiter">
        /// The start delimiter regex for the custom pattern.<br/>
        /// Defaults to `\A|[^0-9A-Za-z]` when not specified.<br/>
        /// Default Value: \A|[^0-9A-Za-z]
        /// </param>
        /// <param name="endDelimiter">
        /// The end delimiter regex for the custom pattern.<br/>
        /// Defaults to `\z|[^0-9A-Za-z]` when not specified.<br/>
        /// Default Value: \z|[^0-9A-Za-z]
        /// </param>
        /// <param name="mustMatch">
        /// List of regexes that the secret must match.
        /// </param>
        /// <param name="mustNotMatch">
        /// List of regexes that the secret must not match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningCustomPatternToCreate(
            string name,
            string pattern,
            string? startDelimiter,
            string? endDelimiter,
            global::System.Collections.Generic.IList<string>? mustMatch,
            global::System.Collections.Generic.IList<string>? mustNotMatch)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.StartDelimiter = startDelimiter;
            this.EndDelimiter = endDelimiter;
            this.MustMatch = mustMatch;
            this.MustNotMatch = mustNotMatch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningCustomPatternToCreate" /> class.
        /// </summary>
        public SecretScanningCustomPatternToCreate()
        {
        }

    }
}