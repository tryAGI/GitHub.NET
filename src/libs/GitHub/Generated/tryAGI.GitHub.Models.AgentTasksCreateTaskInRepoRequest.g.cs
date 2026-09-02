
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentTasksCreateTaskInRepoRequest
    {
        /// <summary>
        /// The user's prompt for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The model to use for this task. The allowed models may change over time and depend on the user's GitHub Copilot plan and organization policies. Currently supported values: `claude-sonnet-4.6`, `claude-opus-4.6`, `gpt-5.2-codex`, `gpt-5.3-codex`, `gpt-5.4`, `claude-sonnet-4.5`, `claude-opus-4.5`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional identifier for a custom agent to use for this task. Use the custom agent's filename without the extension - for example, for a `.github/agents/performance-optimizer.agent.md` custom agent, use `performance-optimizer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_agent")]
        public string? CustomAgent { get; set; }

        /// <summary>
        /// Whether to create a PR.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_pull_request")]
        public bool? CreatePullRequest { get; set; }

        /// <summary>
        /// Base ref for new branch/PR
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_ref")]
        public string? BaseRef { get; set; }

        /// <summary>
        /// Head ref for existing branch/PR. If provided with `base_ref`, the agent looks up open PR context for `head_ref` targeting `base_ref` and commits to `head_ref` instead of creating a new branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_ref")]
        public string? HeadRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksCreateTaskInRepoRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The user's prompt for the agent
        /// </param>
        /// <param name="model">
        /// The model to use for this task. The allowed models may change over time and depend on the user's GitHub Copilot plan and organization policies. Currently supported values: `claude-sonnet-4.6`, `claude-opus-4.6`, `gpt-5.2-codex`, `gpt-5.3-codex`, `gpt-5.4`, `claude-sonnet-4.5`, `claude-opus-4.5`
        /// </param>
        /// <param name="customAgent">
        /// Optional identifier for a custom agent to use for this task. Use the custom agent's filename without the extension - for example, for a `.github/agents/performance-optimizer.agent.md` custom agent, use `performance-optimizer`.
        /// </param>
        /// <param name="createPullRequest">
        /// Whether to create a PR.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="baseRef">
        /// Base ref for new branch/PR
        /// </param>
        /// <param name="headRef">
        /// Head ref for existing branch/PR. If provided with `base_ref`, the agent looks up open PR context for `head_ref` targeting `base_ref` and commits to `head_ref` instead of creating a new branch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksCreateTaskInRepoRequest(
            string prompt,
            string? model,
            string? customAgent,
            bool? createPullRequest,
            string? baseRef,
            string? headRef)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.CustomAgent = customAgent;
            this.CreatePullRequest = createPullRequest;
            this.BaseRef = baseRef;
            this.HeadRef = headRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksCreateTaskInRepoRequest" /> class.
        /// </summary>
        public AgentTasksCreateTaskInRepoRequest()
        {
        }

    }
}