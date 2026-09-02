
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A self hosted runner
    /// </summary>
    public sealed partial class Runner
    {
        /// <summary>
        /// The ID of the runner.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The ID of the runner group.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_group_id")]
        public int? RunnerGroupId { get; set; }

        /// <summary>
        /// The name of the runner.<br/>
        /// Example: iMac
        /// </summary>
        /// <example>iMac</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The Operating System of the runner.<br/>
        /// Example: macos
        /// </summary>
        /// <example>macos</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("os")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Os { get; set; }

        /// <summary>
        /// The status of the runner.<br/>
        /// Example: online
        /// </summary>
        /// <example>online</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("busy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Busy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.RunnerLabel> Labels { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral")]
        public bool? Ephemeral { get; set; }

        /// <summary>
        /// The version of the GitHub Actions Runner software. This is only set if the runner has connected to the service at least once.<br/>
        /// Example: 2.323.0
        /// </summary>
        /// <example>2.323.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Runner" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the runner.<br/>
        /// Example: 5
        /// </param>
        /// <param name="name">
        /// The name of the runner.<br/>
        /// Example: iMac
        /// </param>
        /// <param name="os">
        /// The Operating System of the runner.<br/>
        /// Example: macos
        /// </param>
        /// <param name="status">
        /// The status of the runner.<br/>
        /// Example: online
        /// </param>
        /// <param name="busy"></param>
        /// <param name="labels"></param>
        /// <param name="runnerGroupId">
        /// The ID of the runner group.<br/>
        /// Example: 1
        /// </param>
        /// <param name="ephemeral"></param>
        /// <param name="version">
        /// The version of the GitHub Actions Runner software. This is only set if the runner has connected to the service at least once.<br/>
        /// Example: 2.323.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Runner(
            int id,
            string name,
            string os,
            string status,
            bool busy,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.RunnerLabel> labels,
            int? runnerGroupId,
            bool? ephemeral,
            string? version)
        {
            this.Id = id;
            this.RunnerGroupId = runnerGroupId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Os = os ?? throw new global::System.ArgumentNullException(nameof(os));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Busy = busy;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Ephemeral = ephemeral;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Runner" /> class.
        /// </summary>
        public Runner()
        {
        }

    }
}