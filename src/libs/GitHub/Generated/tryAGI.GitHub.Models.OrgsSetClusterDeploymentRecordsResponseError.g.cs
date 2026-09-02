
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsSetClusterDeploymentRecordsResponseError
    {
        /// <summary>
        /// The reason the deployment failed processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cause")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrgsSetClusterDeploymentRecordsResponseErrorCauseJsonConverter))]
        public global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsResponseErrorCause? Cause { get; set; }

        /// <summary>
        /// The deployment payload that could not be processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsResponseErrorDeployment? Deployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsSetClusterDeploymentRecordsResponseError" /> class.
        /// </summary>
        /// <param name="cause">
        /// The reason the deployment failed processing.
        /// </param>
        /// <param name="deployment">
        /// The deployment payload that could not be processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsSetClusterDeploymentRecordsResponseError(
            global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsResponseErrorCause? cause,
            global::tryAGI.GitHub.OrgsSetClusterDeploymentRecordsResponseErrorDeployment? deployment)
        {
            this.Cause = cause;
            this.Deployment = deployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsSetClusterDeploymentRecordsResponseError" /> class.
        /// </summary>
        public OrgsSetClusterDeploymentRecordsResponseError()
        {
        }

    }
}