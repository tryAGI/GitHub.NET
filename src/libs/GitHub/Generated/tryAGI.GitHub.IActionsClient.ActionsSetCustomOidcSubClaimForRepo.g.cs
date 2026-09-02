#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set the customization template for an OIDC subject claim for a repository<br/>
        /// Sets the customization template and `opt-in` or `opt-out` flag for an OpenID Connect (OIDC) subject claim for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.EmptyObject> ActionsSetCustomOidcSubClaimForRepoAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.ActionsSetCustomOidcSubClaimForRepoRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the customization template for an OIDC subject claim for a repository<br/>
        /// Sets the customization template and `opt-in` or `opt-out` flag for an OpenID Connect (OIDC) subject claim for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.EmptyObject>> ActionsSetCustomOidcSubClaimForRepoAsResponseAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.ActionsSetCustomOidcSubClaimForRepoRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the customization template for an OIDC subject claim for a repository<br/>
        /// Sets the customization template and `opt-in` or `opt-out` flag for an OpenID Connect (OIDC) subject claim for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="useDefault">
        /// Whether to use the default template or not. If `true`, the `include_claim_keys` field is ignored.
        /// </param>
        /// <param name="includeClaimKeys">
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </param>
        /// <param name="useImmutableSubject">
        /// Whether to opt in to the immutable OIDC subject claim format for this repository. When `true`, OIDC tokens will use a stable, repository-ID-based `sub` claim.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.EmptyObject> ActionsSetCustomOidcSubClaimForRepoAsync(
            string owner,
            string repo,
            bool useDefault,
            global::System.Collections.Generic.IList<string>? includeClaimKeys = default,
            bool? useImmutableSubject = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}