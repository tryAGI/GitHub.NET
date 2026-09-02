
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Enforce any added or changed dependencies to comply with the organization's license policy.
    /// </summary>
    public sealed partial class RepositoryRuleLicenseComplianceScanning
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryRuleLicenseComplianceScanningTypeJsonConverter))]
        public global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanningType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleLicenseComplianceScanning" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleLicenseComplianceScanning(
            global::tryAGI.GitHub.RepositoryRuleLicenseComplianceScanningType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleLicenseComplianceScanning" /> class.
        /// </summary>
        public RepositoryRuleLicenseComplianceScanning()
        {
        }

    }
}