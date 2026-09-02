#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Commit an autofix for a code scanning alert<br/>
        /// Commits an autofix for a code scanning alert from the repository's default branch.<br/>
        /// If an autofix is committed as a result of this request, then this endpoint will return a 201 Created response.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeScanningAutofixCommitsResponse> CodeScanningCommitAutofixAsync(
            string owner,
            string repo,
            int alertNumber,

            global::tryAGI.GitHub.CodeScanningAutofixCommits request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Commit an autofix for a code scanning alert<br/>
        /// Commits an autofix for a code scanning alert from the repository's default branch.<br/>
        /// If an autofix is committed as a result of this request, then this endpoint will return a 201 Created response.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CodeScanningAutofixCommitsResponse>> CodeScanningCommitAutofixAsResponseAsync(
            string owner,
            string repo,
            int alertNumber,

            global::tryAGI.GitHub.CodeScanningAutofixCommits request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Commit an autofix for a code scanning alert<br/>
        /// Commits an autofix for a code scanning alert from the repository's default branch.<br/>
        /// If an autofix is committed as a result of this request, then this endpoint will return a 201 Created response.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="targetRef">
        /// The Git reference of target branch for the commit. Branch needs to already exist.  For more information, see "[Git References](https://git-scm.com/book/en/v2/Git-Internals-Git-References)" in the Git documentation.
        /// </param>
        /// <param name="message">
        /// Commit message to be used.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeScanningAutofixCommitsResponse> CodeScanningCommitAutofixAsync(
            string owner,
            string repo,
            int alertNumber,
            string? targetRef = default,
            string? message = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}