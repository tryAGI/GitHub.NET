#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Set primary email visibility for the authenticated user<br/>
        /// Sets the visibility for your primary email addresses.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Email>> UsersSetPrimaryEmailVisibilityForAuthenticatedUserAsync(

            global::tryAGI.GitHub.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set primary email visibility for the authenticated user<br/>
        /// Sets the visibility for your primary email addresses.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Email>>> UsersSetPrimaryEmailVisibilityForAuthenticatedUserAsResponseAsync(

            global::tryAGI.GitHub.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set primary email visibility for the authenticated user<br/>
        /// Sets the visibility for your primary email addresses.
        /// </summary>
        /// <param name="visibility">
        /// Denotes whether an email is publicly visible.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Email>> UsersSetPrimaryEmailVisibilityForAuthenticatedUserAsync(
            global::tryAGI.GitHub.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility visibility,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}