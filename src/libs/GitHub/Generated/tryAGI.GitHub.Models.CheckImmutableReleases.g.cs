
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Check immutable releases
    /// </summary>
    public sealed partial class CheckImmutableReleases
    {
        /// <summary>
        /// Whether immutable releases are enabled for the repository.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Whether immutable releases are enforced by the repository owner.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforced_by_owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnforcedByOwner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckImmutableReleases" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether immutable releases are enabled for the repository.<br/>
        /// Example: true
        /// </param>
        /// <param name="enforcedByOwner">
        /// Whether immutable releases are enforced by the repository owner.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckImmutableReleases(
            bool enabled,
            bool enforcedByOwner)
        {
            this.Enabled = enabled;
            this.EnforcedByOwner = enforcedByOwner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckImmutableReleases" /> class.
        /// </summary>
        public CheckImmutableReleases()
        {
        }

    }
}