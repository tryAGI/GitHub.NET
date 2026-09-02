
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActionsUpdateHostedRunnerForOrgRequest
    {
        /// <summary>
        /// Name of the runner. Must be between 1 and 64 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The existing runner group to add this runner to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_group_id")]
        public int? RunnerGroupId { get; set; }

        /// <summary>
        /// The maximum amount of runners to scale up to. Runners will not auto-scale above this number. Use this setting to limit your cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_runners")]
        public int? MaximumRunners { get; set; }

        /// <summary>
        /// Whether this runner should be updated with a static public IP. Note limit on account. To list limits on account, use `GET actions/hosted-runners/limits`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_static_ip")]
        public bool? EnableStaticIp { get; set; }

        /// <summary>
        /// The machine size of the runner. To list available sizes, use `GET actions/hosted-runners/machine-sizes`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// The source type of the runner image to use. Must match the source of the image specified by `image_id`. Can be one of `github`, `partner`, or `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ActionsUpdateHostedRunnerForOrgRequestImageSourceJsonConverter))]
        public global::tryAGI.GitHub.ActionsUpdateHostedRunnerForOrgRequestImageSource? ImageSource { get; set; }

        /// <summary>
        /// The unique identifier of the runner image. To list available images, use `GET /actions/hosted-runners/images/github-owned`, `GET /actions/hosted-runners/images/partner`, or `GET /actions/hosted-runners/images/custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_id")]
        public string? ImageId { get; set; }

        /// <summary>
        /// The version of the runner image to deploy. This is relevant only for runners using custom images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_version")]
        public string? ImageVersion { get; set; }

        /// <summary>
        /// Whether to enable image generation for this runner pool. When enabled, the runner pool is used to build and publish custom runner images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_gen")]
        public bool? ImageGen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateHostedRunnerForOrgRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the runner. Must be between 1 and 64 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </param>
        /// <param name="runnerGroupId">
        /// The existing runner group to add this runner to.
        /// </param>
        /// <param name="maximumRunners">
        /// The maximum amount of runners to scale up to. Runners will not auto-scale above this number. Use this setting to limit your cost.
        /// </param>
        /// <param name="enableStaticIp">
        /// Whether this runner should be updated with a static public IP. Note limit on account. To list limits on account, use `GET actions/hosted-runners/limits`
        /// </param>
        /// <param name="size">
        /// The machine size of the runner. To list available sizes, use `GET actions/hosted-runners/machine-sizes`
        /// </param>
        /// <param name="imageSource">
        /// The source type of the runner image to use. Must match the source of the image specified by `image_id`. Can be one of `github`, `partner`, or `custom`.
        /// </param>
        /// <param name="imageId">
        /// The unique identifier of the runner image. To list available images, use `GET /actions/hosted-runners/images/github-owned`, `GET /actions/hosted-runners/images/partner`, or `GET /actions/hosted-runners/images/custom`.
        /// </param>
        /// <param name="imageVersion">
        /// The version of the runner image to deploy. This is relevant only for runners using custom images.
        /// </param>
        /// <param name="imageGen">
        /// Whether to enable image generation for this runner pool. When enabled, the runner pool is used to build and publish custom runner images.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsUpdateHostedRunnerForOrgRequest(
            string? name,
            int? runnerGroupId,
            int? maximumRunners,
            bool? enableStaticIp,
            string? size,
            global::tryAGI.GitHub.ActionsUpdateHostedRunnerForOrgRequestImageSource? imageSource,
            string? imageId,
            string? imageVersion,
            bool? imageGen)
        {
            this.Name = name;
            this.RunnerGroupId = runnerGroupId;
            this.MaximumRunners = maximumRunners;
            this.EnableStaticIp = enableStaticIp;
            this.Size = size;
            this.ImageSource = imageSource;
            this.ImageId = imageId;
            this.ImageVersion = imageVersion;
            this.ImageGen = imageGen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateHostedRunnerForOrgRequest" /> class.
        /// </summary>
        public ActionsUpdateHostedRunnerForOrgRequest()
        {
        }

    }
}