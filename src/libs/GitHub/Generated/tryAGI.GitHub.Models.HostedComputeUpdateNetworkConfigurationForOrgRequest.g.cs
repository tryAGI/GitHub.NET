
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedComputeUpdateNetworkConfigurationForOrgRequest
    {
        /// <summary>
        /// Name of the network configuration. Must be between 1 and 100 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The hosted compute service to use for the network configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_service")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.HostedComputeUpdateNetworkConfigurationForOrgRequestComputeServiceJsonConverter))]
        public global::tryAGI.GitHub.HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService? ComputeService { get; set; }

        /// <summary>
        /// A list of identifiers of the network settings resources to use for the network configuration. Exactly one resource identifier must be specified in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_settings_ids")]
        public global::System.Collections.Generic.IList<string>? NetworkSettingsIds { get; set; }

        /// <summary>
        /// A list of identifiers of the failover network settings resources to use for the network configuration. Exactly one resource identifier must be specified in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failover_network_settings_ids")]
        public global::System.Collections.Generic.IList<string>? FailoverNetworkSettingsIds { get; set; }

        /// <summary>
        /// Indicates whether the failover network resource is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failover_network_enabled")]
        public bool? FailoverNetworkEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedComputeUpdateNetworkConfigurationForOrgRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the network configuration. Must be between 1 and 100 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </param>
        /// <param name="computeService">
        /// The hosted compute service to use for the network configuration.
        /// </param>
        /// <param name="networkSettingsIds">
        /// A list of identifiers of the network settings resources to use for the network configuration. Exactly one resource identifier must be specified in the list.
        /// </param>
        /// <param name="failoverNetworkSettingsIds">
        /// A list of identifiers of the failover network settings resources to use for the network configuration. Exactly one resource identifier must be specified in the list.
        /// </param>
        /// <param name="failoverNetworkEnabled">
        /// Indicates whether the failover network resource is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedComputeUpdateNetworkConfigurationForOrgRequest(
            string? name,
            global::tryAGI.GitHub.HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService? computeService,
            global::System.Collections.Generic.IList<string>? networkSettingsIds,
            global::System.Collections.Generic.IList<string>? failoverNetworkSettingsIds,
            bool? failoverNetworkEnabled)
        {
            this.Name = name;
            this.ComputeService = computeService;
            this.NetworkSettingsIds = networkSettingsIds;
            this.FailoverNetworkSettingsIds = failoverNetworkSettingsIds;
            this.FailoverNetworkEnabled = failoverNetworkEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedComputeUpdateNetworkConfigurationForOrgRequest" /> class.
        /// </summary>
        public HostedComputeUpdateNetworkConfigurationForOrgRequest()
        {
        }

    }
}