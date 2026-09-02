
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CodeSecuritySetConfigurationAsDefaultResponse
    {
        /// <summary>
        /// Specifies which types of repository this security configuration is applied to by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_for_new_repos")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewReposJsonConverter))]
        public global::tryAGI.GitHub.CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos? DefaultForNewRepos { get; set; }

        /// <summary>
        /// A code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::tryAGI.GitHub.CodeSecurityConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecuritySetConfigurationAsDefaultResponse" /> class.
        /// </summary>
        /// <param name="defaultForNewRepos">
        /// Specifies which types of repository this security configuration is applied to by default.
        /// </param>
        /// <param name="configuration">
        /// A code security configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecuritySetConfigurationAsDefaultResponse(
            global::tryAGI.GitHub.CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos? defaultForNewRepos,
            global::tryAGI.GitHub.CodeSecurityConfiguration? configuration)
        {
            this.DefaultForNewRepos = defaultForNewRepos;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecuritySetConfigurationAsDefaultResponse" /> class.
        /// </summary>
        public CodeSecuritySetConfigurationAsDefaultResponse()
        {
        }

    }
}