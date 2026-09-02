
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Repository hash algorithm
    /// </summary>
    public sealed partial class RepositoryHashAlgorithm
    {
        /// <summary>
        /// The Git hash algorithm used by this repository.<br/>
        /// Example: sha1
        /// </summary>
        /// <example>sha1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash_algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryHashAlgorithmHashAlgorithmJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.RepositoryHashAlgorithmHashAlgorithm HashAlgorithm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryHashAlgorithm" /> class.
        /// </summary>
        /// <param name="hashAlgorithm">
        /// The Git hash algorithm used by this repository.<br/>
        /// Example: sha1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryHashAlgorithm(
            global::tryAGI.GitHub.RepositoryHashAlgorithmHashAlgorithm hashAlgorithm)
        {
            this.HashAlgorithm = hashAlgorithm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryHashAlgorithm" /> class.
        /// </summary>
        public RepositoryHashAlgorithm()
        {
        }

    }
}