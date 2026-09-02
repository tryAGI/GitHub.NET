#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Check if a user follows another user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="targetUser"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersCheckFollowingForUserAsync(
            string username,
            string targetUser,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check if a user follows another user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="targetUser"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> UsersCheckFollowingForUserAsResponseAsync(
            string username,
            string targetUser,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}