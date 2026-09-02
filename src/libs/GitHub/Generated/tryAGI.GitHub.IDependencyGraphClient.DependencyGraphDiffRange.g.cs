#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IDependencyGraphClient
    {
        /// <summary>
        /// Get a diff of the dependencies between commits<br/>
        /// Gets the diff of the dependency changes between two commits of a repository, based on the changes to the dependency manifests made in those commits.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="basehead"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependencyGraphDiffItem>> DependencyGraphDiffRangeAsync(
            string owner,
            string repo,
            string basehead,
            string? name = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a diff of the dependencies between commits<br/>
        /// Gets the diff of the dependency changes between two commits of a repository, based on the changes to the dependency manifests made in those commits.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="basehead"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependencyGraphDiffItem>>> DependencyGraphDiffRangeAsResponseAsync(
            string owner,
            string repo,
            string basehead,
            string? name = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}