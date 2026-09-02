
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequest
    {
        /// <summary>
        /// The default repository access level for Dependabot updates.<br/>
        /// Example: internal
        /// </summary>
        /// <example>internal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevel DefaultLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequest" /> class.
        /// </summary>
        /// <param name="defaultLevel">
        /// The default repository access level for Dependabot updates.<br/>
        /// Example: internal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequest(
            global::tryAGI.GitHub.DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequestDefaultLevel defaultLevel)
        {
            this.DefaultLevel = defaultLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequest" /> class.
        /// </summary>
        public DependabotSetRepositoryAccessDefaultLevelForEnterpriseRequest()
        {
        }

    }
}