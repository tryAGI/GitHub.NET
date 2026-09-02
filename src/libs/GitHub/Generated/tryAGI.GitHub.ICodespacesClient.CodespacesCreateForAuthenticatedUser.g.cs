#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Create a codespace for the authenticated user<br/>
        /// Creates a new codespace, owned by the authenticated user.<br/>
        /// This endpoint requires either a `repository_id` OR a `pull_request` but not both.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Codespace> CodespacesCreateForAuthenticatedUserAsync(

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.CodespacesCreateForAuthenticatedUserRequestVariant1, global::tryAGI.GitHub.CodespacesCreateForAuthenticatedUserRequestVariant2> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a codespace for the authenticated user<br/>
        /// Creates a new codespace, owned by the authenticated user.<br/>
        /// This endpoint requires either a `repository_id` OR a `pull_request` but not both.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.Codespace>> CodespacesCreateForAuthenticatedUserAsResponseAsync(

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.CodespacesCreateForAuthenticatedUserRequestVariant1, global::tryAGI.GitHub.CodespacesCreateForAuthenticatedUserRequestVariant2> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a codespace for the authenticated user<br/>
        /// Creates a new codespace, owned by the authenticated user.<br/>
        /// This endpoint requires either a `repository_id` OR a `pull_request` but not both.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Codespace> CodespacesCreateForAuthenticatedUserAsync(
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}