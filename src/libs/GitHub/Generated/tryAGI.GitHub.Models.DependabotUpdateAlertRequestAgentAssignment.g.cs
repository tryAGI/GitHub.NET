
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Parameters for AI agent assignment. Only used when an agent bot login is<br/>
    /// included in `assignees`. Ignored when no agent is being assigned.
    /// </summary>
    public sealed partial class DependabotUpdateAlertRequestAgentAssignment
    {
        /// <summary>
        /// Custom instructions for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public string? CustomInstructions { get; set; }

        /// <summary>
        /// A custom agent identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_agent")]
        public string? CustomAgent { get; set; }

        /// <summary>
        /// The model to use for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotUpdateAlertRequestAgentAssignment" /> class.
        /// </summary>
        /// <param name="customInstructions">
        /// Custom instructions for the agent.
        /// </param>
        /// <param name="customAgent">
        /// A custom agent identifier.
        /// </param>
        /// <param name="model">
        /// The model to use for the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotUpdateAlertRequestAgentAssignment(
            string? customInstructions,
            string? customAgent,
            string? model)
        {
            this.CustomInstructions = customInstructions;
            this.CustomAgent = customAgent;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotUpdateAlertRequestAgentAssignment" /> class.
        /// </summary>
        public DependabotUpdateAlertRequestAgentAssignment()
        {
        }

    }
}