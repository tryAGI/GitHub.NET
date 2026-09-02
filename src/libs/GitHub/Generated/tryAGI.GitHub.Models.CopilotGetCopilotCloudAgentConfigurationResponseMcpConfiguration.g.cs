
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The user-supplied MCP server configuration for the repository, as a free-form JSON object. This will be set to `null` if no configuration has been set.<br/>
    /// The shape of a valid MCP configuration may evolve over time, so this property is intentionally not strictly typed. Clients should not assume a fixed schema.
    /// </summary>
    public sealed partial class CopilotGetCopilotCloudAgentConfigurationResponseMcpConfiguration
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}