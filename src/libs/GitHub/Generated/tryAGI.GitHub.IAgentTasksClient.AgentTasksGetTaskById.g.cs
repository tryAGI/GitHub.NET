#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IAgentTasksClient
    {
        /// <summary>
        /// Get a task by ID<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Returns a task by ID with its associated sessions<br/>
        /// **Fine-grained access tokens for "Get a task by ID"**<br/>
        /// This endpoint works with the following fine-grained token types:<br/>
        /// * [GitHub App user access tokens](https://docs.github.com/en/apps/creating-github-apps/authenticating-with-a-github-app/generating-a-user-access-token-for-a-github-app)<br/>
        /// * [Fine-grained personal access tokens](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens#creating-a-fine-grained-personal-access-token)<br/>
        /// The fine-grained token must have the following permission set:<br/>
        /// * "Agent tasks" repository permissions (read)<br/>
        /// GitHub App installation access tokens are not supported for this endpoint.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant1, global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2>> AgentTasksGetTaskByIdAsync(
            string taskId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a task by ID<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Returns a task by ID with its associated sessions<br/>
        /// **Fine-grained access tokens for "Get a task by ID"**<br/>
        /// This endpoint works with the following fine-grained token types:<br/>
        /// * [GitHub App user access tokens](https://docs.github.com/en/apps/creating-github-apps/authenticating-with-a-github-app/generating-a-user-access-token-for-a-github-app)<br/>
        /// * [Fine-grained personal access tokens](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens#creating-a-fine-grained-personal-access-token)<br/>
        /// The fine-grained token must have the following permission set:<br/>
        /// * "Agent tasks" repository permissions (read)<br/>
        /// GitHub App installation access tokens are not supported for this endpoint.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant1, global::tryAGI.GitHub.AgentTasksGetTaskByIdResponseVariant2>>> AgentTasksGetTaskByIdAsResponseAsync(
            string taskId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}