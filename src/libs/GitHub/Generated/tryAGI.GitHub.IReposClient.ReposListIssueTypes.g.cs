#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List issue types for a repository<br/>
        /// Lists issue types available for a repository (inherited from its organization owner, with any per-repository overrides applied).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.<br/>
        /// Fine-grained access tokens require the "Metadata" repository permission (read).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueType?>> ReposListIssueTypesAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List issue types for a repository<br/>
        /// Lists issue types available for a repository (inherited from its organization owner, with any per-repository overrides applied).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.<br/>
        /// Fine-grained access tokens require the "Metadata" repository permission (read).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueType?>>> ReposListIssueTypesAsResponseAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}