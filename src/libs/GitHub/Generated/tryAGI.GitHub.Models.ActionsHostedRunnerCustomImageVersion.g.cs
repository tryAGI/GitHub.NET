
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Provides details of a hosted runner custom image version
    /// </summary>
    public sealed partial class ActionsHostedRunnerCustomImageVersion
    {
        /// <summary>
        /// The version of image.<br/>
        /// Example: 1.0.0
        /// </summary>
        /// <example>1.0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// The state of image version.<br/>
        /// Example: Ready
        /// </summary>
        /// <example>Ready</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// Image version size in GB.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeGb { get; set; }

        /// <summary>
        /// The creation date time of the image version.<br/>
        /// Example: 2024-11-09T23:39:01Z
        /// </summary>
        /// <example>2024-11-09T23:39:01Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedOn { get; set; }

        /// <summary>
        /// The image version status details.<br/>
        /// Example: None
        /// </summary>
        /// <example>None</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StateDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerCustomImageVersion" /> class.
        /// </summary>
        /// <param name="version">
        /// The version of image.<br/>
        /// Example: 1.0.0
        /// </param>
        /// <param name="state">
        /// The state of image version.<br/>
        /// Example: Ready
        /// </param>
        /// <param name="sizeGb">
        /// Image version size in GB.<br/>
        /// Example: 30
        /// </param>
        /// <param name="createdOn">
        /// The creation date time of the image version.<br/>
        /// Example: 2024-11-09T23:39:01Z
        /// </param>
        /// <param name="stateDetails">
        /// The image version status details.<br/>
        /// Example: None
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsHostedRunnerCustomImageVersion(
            string version,
            string state,
            int sizeGb,
            string createdOn,
            string stateDetails)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.SizeGb = sizeGb;
            this.CreatedOn = createdOn ?? throw new global::System.ArgumentNullException(nameof(createdOn));
            this.StateDetails = stateDetails ?? throw new global::System.ArgumentNullException(nameof(stateDetails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerCustomImageVersion" /> class.
        /// </summary>
        public ActionsHostedRunnerCustomImageVersion()
        {
        }

    }
}