#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IAgentTasksClient
    {
        /// <summary>
        /// Start a task<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Starts a new Copilot cloud agent task for a repository.<br/>
        /// This endpoint is only available to users with a Copilot Business or Copilot Enterprise subscription.<br/>
        /// **Fine-grained access tokens for "Start a task"**<br/>
        /// This endpoint works with the following fine-grained token types:<br/>
        /// * [GitHub App user access tokens](https://docs.github.com/en/apps/creating-github-apps/authenticating-with-a-github-app/generating-a-user-access-token-for-a-github-app)<br/>
        /// * [Fine-grained personal access tokens](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens#creating-a-fine-grained-personal-access-token)<br/>
        /// The fine-grained token must have the following permission set:<br/>
        /// * "Agent tasks" repository permissions (read and write)<br/>
        /// GitHub App installation access tokens are not supported for this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AgentTasksCreateTaskInRepoResponse> AgentTasksCreateTaskInRepoAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.AgentTasksCreateTaskInRepoRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a task<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Starts a new Copilot cloud agent task for a repository.<br/>
        /// This endpoint is only available to users with a Copilot Business or Copilot Enterprise subscription.<br/>
        /// **Fine-grained access tokens for "Start a task"**<br/>
        /// This endpoint works with the following fine-grained token types:<br/>
        /// * [GitHub App user access tokens](https://docs.github.com/en/apps/creating-github-apps/authenticating-with-a-github-app/generating-a-user-access-token-for-a-github-app)<br/>
        /// * [Fine-grained personal access tokens](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens#creating-a-fine-grained-personal-access-token)<br/>
        /// The fine-grained token must have the following permission set:<br/>
        /// * "Agent tasks" repository permissions (read and write)<br/>
        /// GitHub App installation access tokens are not supported for this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.AgentTasksCreateTaskInRepoResponse>> AgentTasksCreateTaskInRepoAsResponseAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.AgentTasksCreateTaskInRepoRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a task<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Starts a new Copilot cloud agent task for a repository.<br/>
        /// This endpoint is only available to users with a Copilot Business or Copilot Enterprise subscription.<br/>
        /// **Fine-grained access tokens for "Start a task"**<br/>
        /// This endpoint works with the following fine-grained token types:<br/>
        /// * [GitHub App user access tokens](https://docs.github.com/en/apps/creating-github-apps/authenticating-with-a-github-app/generating-a-user-access-token-for-a-github-app)<br/>
        /// * [Fine-grained personal access tokens](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens#creating-a-fine-grained-personal-access-token)<br/>
        /// The fine-grained token must have the following permission set:<br/>
        /// * "Agent tasks" repository permissions (read and write)<br/>
        /// GitHub App installation access tokens are not supported for this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AgentTasksCreateTaskInRepoResponse> AgentTasksCreateTaskInRepoAsync(
            string owner,
            string repo,
            string prompt,
            string? model = default,
            string? customAgent = default,
            bool? createPullRequest = default,
            string? baseRef = default,
            string? headRef = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}