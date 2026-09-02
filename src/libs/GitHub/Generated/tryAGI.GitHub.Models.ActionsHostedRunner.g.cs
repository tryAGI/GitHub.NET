
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A Github-hosted hosted runner.
    /// </summary>
    public sealed partial class ActionsHostedRunner
    {
        /// <summary>
        /// The unique identifier of the hosted runner.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the hosted runner.<br/>
        /// Example: my-github-hosted-runner
        /// </summary>
        /// <example>my-github-hosted-runner</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The unique identifier of the group that the hosted runner belongs to.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_group_id")]
        public int? RunnerGroupId { get; set; }

        /// <summary>
        /// Provides details of a hosted runner image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_details")]
        public global::tryAGI.GitHub.NullableActionsHostedRunnerPoolImage? ImageDetails { get; set; }

        /// <summary>
        /// Provides details of a particular machine spec.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machine_size_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ActionsHostedRunnerMachineSpec MachineSizeDetails { get; set; }

        /// <summary>
        /// The status of the runner.<br/>
        /// Example: Ready
        /// </summary>
        /// <example>Ready</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ActionsHostedRunnerStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ActionsHostedRunnerStatus Status { get; set; }

        /// <summary>
        /// The operating system of the image.<br/>
        /// Example: linux-x64
        /// </summary>
        /// <example>linux-x64</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Platform { get; set; }

        /// <summary>
        /// The maximum amount of hosted runners. Runners will not scale automatically above this number. Use this setting to limit your cost.<br/>
        /// Default Value: 10<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_runners")]
        public int? MaximumRunners { get; set; }

        /// <summary>
        /// Whether public IP is enabled for the hosted runners.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_ip_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PublicIpEnabled { get; set; }

        /// <summary>
        /// The public IP ranges when public IP is enabled for the hosted runners.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_ips")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.PublicIp>? PublicIps { get; set; }

        /// <summary>
        /// The time at which the runner was last used, in ISO 8601 format.<br/>
        /// Example: 2022-10-09T23:39:01Z
        /// </summary>
        /// <example>2022-10-09T23:39:01Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active_on")]
        public global::System.DateTime? LastActiveOn { get; set; }

        /// <summary>
        /// Whether custom image generation is enabled for the hosted runners.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_gen")]
        public bool? ImageGen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunner" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the hosted runner.<br/>
        /// Example: 5
        /// </param>
        /// <param name="name">
        /// The name of the hosted runner.<br/>
        /// Example: my-github-hosted-runner
        /// </param>
        /// <param name="machineSizeDetails">
        /// Provides details of a particular machine spec.
        /// </param>
        /// <param name="status">
        /// The status of the runner.<br/>
        /// Example: Ready
        /// </param>
        /// <param name="platform">
        /// The operating system of the image.<br/>
        /// Example: linux-x64
        /// </param>
        /// <param name="publicIpEnabled">
        /// Whether public IP is enabled for the hosted runners.<br/>
        /// Example: true
        /// </param>
        /// <param name="runnerGroupId">
        /// The unique identifier of the group that the hosted runner belongs to.<br/>
        /// Example: 2
        /// </param>
        /// <param name="imageDetails">
        /// Provides details of a hosted runner image
        /// </param>
        /// <param name="maximumRunners">
        /// The maximum amount of hosted runners. Runners will not scale automatically above this number. Use this setting to limit your cost.<br/>
        /// Default Value: 10<br/>
        /// Example: 5
        /// </param>
        /// <param name="publicIps">
        /// The public IP ranges when public IP is enabled for the hosted runners.
        /// </param>
        /// <param name="lastActiveOn">
        /// The time at which the runner was last used, in ISO 8601 format.<br/>
        /// Example: 2022-10-09T23:39:01Z
        /// </param>
        /// <param name="imageGen">
        /// Whether custom image generation is enabled for the hosted runners.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsHostedRunner(
            int id,
            string name,
            global::tryAGI.GitHub.ActionsHostedRunnerMachineSpec machineSizeDetails,
            global::tryAGI.GitHub.ActionsHostedRunnerStatus status,
            string platform,
            bool publicIpEnabled,
            int? runnerGroupId,
            global::tryAGI.GitHub.NullableActionsHostedRunnerPoolImage? imageDetails,
            int? maximumRunners,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.PublicIp>? publicIps,
            global::System.DateTime? lastActiveOn,
            bool? imageGen)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RunnerGroupId = runnerGroupId;
            this.ImageDetails = imageDetails;
            this.MachineSizeDetails = machineSizeDetails ?? throw new global::System.ArgumentNullException(nameof(machineSizeDetails));
            this.Status = status;
            this.Platform = platform ?? throw new global::System.ArgumentNullException(nameof(platform));
            this.MaximumRunners = maximumRunners;
            this.PublicIpEnabled = publicIpEnabled;
            this.PublicIps = publicIps;
            this.LastActiveOn = lastActiveOn;
            this.ImageGen = imageGen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunner" /> class.
        /// </summary>
        public ActionsHostedRunner()
        {
        }

    }
}