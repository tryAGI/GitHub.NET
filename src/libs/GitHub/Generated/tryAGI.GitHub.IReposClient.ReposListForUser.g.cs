#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List repositories for a user<br/>
        /// Lists public repositories for the specified user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="type">
        /// Default Value: owner
        /// </param>
        /// <param name="sort">
        /// Default Value: full_name
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.MinimalRepository>> ReposListForUserAsync(
            string username,
            global::tryAGI.GitHub.ReposListForUserType? type = default,
            global::tryAGI.GitHub.ReposListForUserSort? sort = default,
            global::tryAGI.GitHub.ReposListForUserDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List repositories for a user<br/>
        /// Lists public repositories for the specified user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="type">
        /// Default Value: owner
        /// </param>
        /// <param name="sort">
        /// Default Value: full_name
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.MinimalRepository>>> ReposListForUserAsResponseAsync(
            string username,
            global::tryAGI.GitHub.ReposListForUserType? type = default,
            global::tryAGI.GitHub.ReposListForUserSort? sort = default,
            global::tryAGI.GitHub.ReposListForUserDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}