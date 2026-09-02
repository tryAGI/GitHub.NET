
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A hosted compute network configuration.
    /// </summary>
    public sealed partial class NetworkConfiguration
    {
        /// <summary>
        /// The unique identifier of the network configuration.<br/>
        /// Example: 123ABC456DEF789
        /// </summary>
        /// <example>123ABC456DEF789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the network configuration.<br/>
        /// Example: my-network-configuration
        /// </summary>
        /// <example>my-network-configuration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The hosted compute service the network configuration supports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_service")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.NetworkConfigurationComputeServiceJsonConverter))]
        public global::tryAGI.GitHub.NetworkConfigurationComputeService? ComputeService { get; set; }

        /// <summary>
        /// The unique identifier of each network settings in the configuration.<br/>
        /// Example: 123ABC456DEF789
        /// </summary>
        /// <example>123ABC456DEF789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_settings_ids")]
        public global::System.Collections.Generic.IList<string>? NetworkSettingsIds { get; set; }

        /// <summary>
        /// The unique identifier of each failover network settings in the configuration.<br/>
        /// Example: 123ABC456DEF789
        /// </summary>
        /// <example>123ABC456DEF789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failover_network_settings_ids")]
        public global::System.Collections.Generic.IList<string>? FailoverNetworkSettingsIds { get; set; }

        /// <summary>
        /// Indicates whether the failover network resource is enabled.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("failover_network_enabled")]
        public bool? FailoverNetworkEnabled { get; set; }

        /// <summary>
        /// The time at which the network configuration was created, in ISO 8601 format.<br/>
        /// Example: 2024-04-26T11:31:07Z
        /// </summary>
        /// <example>2024-04-26T11:31:07Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_on")]
        public global::System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConfiguration" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the network configuration.<br/>
        /// Example: 123ABC456DEF789
        /// </param>
        /// <param name="name">
        /// The name of the network configuration.<br/>
        /// Example: my-network-configuration
        /// </param>
        /// <param name="computeService">
        /// The hosted compute service the network configuration supports.
        /// </param>
        /// <param name="networkSettingsIds">
        /// The unique identifier of each network settings in the configuration.<br/>
        /// Example: 123ABC456DEF789
        /// </param>
        /// <param name="failoverNetworkSettingsIds">
        /// The unique identifier of each failover network settings in the configuration.<br/>
        /// Example: 123ABC456DEF789
        /// </param>
        /// <param name="failoverNetworkEnabled">
        /// Indicates whether the failover network resource is enabled.<br/>
        /// Example: true
        /// </param>
        /// <param name="createdOn">
        /// The time at which the network configuration was created, in ISO 8601 format.<br/>
        /// Example: 2024-04-26T11:31:07Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkConfiguration(
            string id,
            string name,
            global::tryAGI.GitHub.NetworkConfigurationComputeService? computeService,
            global::System.Collections.Generic.IList<string>? networkSettingsIds,
            global::System.Collections.Generic.IList<string>? failoverNetworkSettingsIds,
            bool? failoverNetworkEnabled,
            global::System.DateTime? createdOn)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ComputeService = computeService;
            this.NetworkSettingsIds = networkSettingsIds;
            this.FailoverNetworkSettingsIds = failoverNetworkSettingsIds;
            this.FailoverNetworkEnabled = failoverNetworkEnabled;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConfiguration" /> class.
        /// </summary>
        public NetworkConfiguration()
        {
        }

    }
}