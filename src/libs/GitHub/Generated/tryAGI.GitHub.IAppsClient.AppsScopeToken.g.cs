#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Create a scoped access token<br/>
        /// Use a non-scoped user access token to create a repository-scoped and/or permission-scoped user access token. You can specify<br/>
        /// which repositories the token can access and which permissions are granted to the<br/>
        /// token.<br/>
        /// Invalid tokens will return `404 NOT FOUND`.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Authorization> AppsScopeTokenAsync(
            string clientId,

            global::tryAGI.GitHub.AppsScopeTokenRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a scoped access token<br/>
        /// Use a non-scoped user access token to create a repository-scoped and/or permission-scoped user access token. You can specify<br/>
        /// which repositories the token can access and which permissions are granted to the<br/>
        /// token.<br/>
        /// Invalid tokens will return `404 NOT FOUND`.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.Authorization>> AppsScopeTokenAsResponseAsync(
            string clientId,

            global::tryAGI.GitHub.AppsScopeTokenRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a scoped access token<br/>
        /// Use a non-scoped user access token to create a repository-scoped and/or permission-scoped user access token. You can specify<br/>
        /// which repositories the token can access and which permissions are granted to the<br/>
        /// token.<br/>
        /// Invalid tokens will return `404 NOT FOUND`.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="accessToken">
        /// The access token used to authenticate to the GitHub API.<br/>
        /// Example: e72e16c7e42f292c6912e7710c838347ae178b4a
        /// </param>
        /// <param name="target">
        /// The name of the user or organization to scope the user access token to. **Required** unless `target_id` is specified.<br/>
        /// Example: octocat
        /// </param>
        /// <param name="targetId">
        /// The ID of the user or organization to scope the user access token to. **Required** unless `target` is specified.<br/>
        /// Example: 1
        /// </param>
        /// <param name="repositories">
        /// The list of repository names to scope the user access token to. `repositories` may not be specified if `repository_ids` is specified.
        /// </param>
        /// <param name="repositoryIds">
        /// The list of repository IDs to scope the user access token to. `repository_ids` may not be specified if `repositories` is specified.<br/>
        /// Example: [1]
        /// </param>
        /// <param name="permissions">
        /// The permissions granted to the fine-grained access token.<br/>
        /// Example: {"contents":"read","issues":"read","deployments":"write","single_file":"read"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Authorization> AppsScopeTokenAsync(
            string clientId,
            string accessToken,
            string? target = default,
            int? targetId = default,
            global::System.Collections.Generic.IList<string>? repositories = default,
            global::System.Collections.Generic.IList<int>? repositoryIds = default,
            global::tryAGI.GitHub.AppPermissions? permissions = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}