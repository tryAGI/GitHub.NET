#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Update a codespace for the authenticated user<br/>
        /// Updates a codespace owned by the authenticated user. Currently only the codespace's machine type and recent folders can be modified using this endpoint.<br/>
        /// If you specify a new machine type it will be applied the next time your codespace is started.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Codespace> CodespacesUpdateForAuthenticatedUserAsync(
            string codespaceName,

            global::tryAGI.GitHub.CodespacesUpdateForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a codespace for the authenticated user<br/>
        /// Updates a codespace owned by the authenticated user. Currently only the codespace's machine type and recent folders can be modified using this endpoint.<br/>
        /// If you specify a new machine type it will be applied the next time your codespace is started.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.Codespace>> CodespacesUpdateForAuthenticatedUserAsResponseAsync(
            string codespaceName,

            global::tryAGI.GitHub.CodespacesUpdateForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a codespace for the authenticated user<br/>
        /// Updates a codespace owned by the authenticated user. Currently only the codespace's machine type and recent folders can be modified using this endpoint.<br/>
        /// If you specify a new machine type it will be applied the next time your codespace is started.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="machine">
        /// A valid machine to transition this codespace to.
        /// </param>
        /// <param name="displayName">
        /// Display name for this codespace
        /// </param>
        /// <param name="recentFolders">
        /// Recently opened folders inside the codespace. It is currently used by the clients to determine the folder path to load the codespace in.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.Codespace> CodespacesUpdateForAuthenticatedUserAsync(
            string codespaceName,
            string? machine = default,
            string? displayName = default,
            global::System.Collections.Generic.IList<string>? recentFolders = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}