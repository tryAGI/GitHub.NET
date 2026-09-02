#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IAgentTasksClient
    {
        /// <summary>
        /// List tasks<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Returns a list of tasks for the authenticated user<br/>
        /// **Fine-grained access tokens for "List tasks"**<br/>
        /// This endpoint works with the following fine-grained token types:<br/>
        /// * [GitHub App user access tokens](https://docs.github.com/en/apps/creating-github-apps/authenticating-with-a-github-app/generating-a-user-access-token-for-a-github-app)<br/>
        /// * [Fine-grained personal access tokens](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens#creating-a-fine-grained-personal-access-token)<br/>
        /// The fine-grained token must have the following permission set:<br/>
        /// * "Agent tasks" repository permissions (read)<br/>
        /// GitHub App installation access tokens are not supported for this endpoint.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="sort">
        /// Default Value: updated_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="state"></param>
        /// <param name="isArchived">
        /// Default Value: false
        /// </param>
        /// <param name="since"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AgentTasksListTasksResponse> AgentTasksListTasksAsync(
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AgentTasksListTasksSort? sort = default,
            global::tryAGI.GitHub.AgentTasksListTasksDirection? direction = default,
            string? state = default,
            bool? isArchived = default,
            global::System.DateTime? since = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List tasks<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Returns a list of tasks for the authenticated user<br/>
        /// **Fine-grained access tokens for "List tasks"**<br/>
        /// This endpoint works with the following fine-grained token types:<br/>
        /// * [GitHub App user access tokens](https://docs.github.com/en/apps/creating-github-apps/authenticating-with-a-github-app/generating-a-user-access-token-for-a-github-app)<br/>
        /// * [Fine-grained personal access tokens](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens#creating-a-fine-grained-personal-access-token)<br/>
        /// The fine-grained token must have the following permission set:<br/>
        /// * "Agent tasks" repository permissions (read)<br/>
        /// GitHub App installation access tokens are not supported for this endpoint.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="sort">
        /// Default Value: updated_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="state"></param>
        /// <param name="isArchived">
        /// Default Value: false
        /// </param>
        /// <param name="since"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.AgentTasksListTasksResponse>> AgentTasksListTasksAsResponseAsync(
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AgentTasksListTasksSort? sort = default,
            global::tryAGI.GitHub.AgentTasksListTasksDirection? direction = default,
            string? state = default,
            bool? isArchived = default,
            global::System.DateTime? since = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps AgentTasksListTasksAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.AgentTasksListTasksResponseTask&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="sort">
        /// Default Value: updated_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="state"></param>
        /// <param name="isArchived">
        /// Default Value: false
        /// </param>
        /// <param name="since"></param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.AgentTasksListTasksResponseTask> AgentTasksListTasksAutoPagingAsync(
              int? perPage = default,
            global::tryAGI.GitHub.AgentTasksListTasksSort? sort = default,
            global::tryAGI.GitHub.AgentTasksListTasksDirection? direction = default,
            string? state = default,
            bool? isArchived = default,
            global::System.DateTime? since = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}