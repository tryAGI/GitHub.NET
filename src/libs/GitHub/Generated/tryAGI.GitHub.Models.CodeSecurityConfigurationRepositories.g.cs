
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Repositories associated with a code security configuration and attachment status
    /// </summary>
    public sealed partial class CodeSecurityConfigurationRepositories
    {
        /// <summary>
        /// The attachment status of the code security configuration on the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationRepositoriesStatusJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationRepositoriesStatus? Status { get; set; }

        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::tryAGI.GitHub.SimpleRepository? Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationRepositories" /> class.
        /// </summary>
        /// <param name="status">
        /// The attachment status of the code security configuration on the repository.
        /// </param>
        /// <param name="repository">
        /// A GitHub repository.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecurityConfigurationRepositories(
            global::tryAGI.GitHub.CodeSecurityConfigurationRepositoriesStatus? status,
            global::tryAGI.GitHub.SimpleRepository? repository)
        {
            this.Status = status;
            this.Repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationRepositories" /> class.
        /// </summary>
        public CodeSecurityConfigurationRepositories()
        {
        }

    }
}