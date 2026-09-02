
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Prevent commits that include changes in specified file and folder paths from being pushed to the commit graph. This includes absolute paths that contain file names.
    /// </summary>
    public sealed partial class RepositoryRuleFilePathRestriction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryRuleFilePathRestrictionTypeJsonConverter))]
        public global::tryAGI.GitHub.RepositoryRuleFilePathRestrictionType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::tryAGI.GitHub.RepositoryRuleFilePathRestrictionParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleFilePathRestriction" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleFilePathRestriction(
            global::tryAGI.GitHub.RepositoryRuleFilePathRestrictionType type,
            global::tryAGI.GitHub.RepositoryRuleFilePathRestrictionParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleFilePathRestriction" /> class.
        /// </summary>
        public RepositoryRuleFilePathRestriction()
        {
        }

    }
}