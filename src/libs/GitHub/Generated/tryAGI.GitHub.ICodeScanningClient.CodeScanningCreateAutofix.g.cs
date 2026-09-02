#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Create an autofix for a code scanning alert<br/>
        /// Creates an autofix for a code scanning alert from the repository's default branch.<br/>
        /// If a new autofix is to be created as a result of this request or is currently being generated, then this endpoint will return a 202 Accepted response.<br/>
        /// If an autofix already exists for a given alert, then this endpoint will return a 200 OK response.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeScanningAutofix> CodeScanningCreateAutofixAsync(
            string owner,
            string repo,
            int alertNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an autofix for a code scanning alert<br/>
        /// Creates an autofix for a code scanning alert from the repository's default branch.<br/>
        /// If a new autofix is to be created as a result of this request or is currently being generated, then this endpoint will return a 202 Accepted response.<br/>
        /// If an autofix already exists for a given alert, then this endpoint will return a 200 OK response.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CodeScanningAutofix>> CodeScanningCreateAutofixAsResponseAsync(
            string owner,
            string repo,
            int alertNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}