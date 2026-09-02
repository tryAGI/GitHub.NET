#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Set labels for an issue<br/>
        /// Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Label>> IssuesSetLabelsAsync(
            string owner,
            string repo,
            int issueNumber,

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.IssuesSetLabelsRequestVariant1, global::System.Collections.Generic.IList<string>, global::tryAGI.GitHub.IssuesSetLabelsRequestVariant3, global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesSetLabelsRequestVariant4Item>, string> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set labels for an issue<br/>
        /// Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Label>>> IssuesSetLabelsAsResponseAsync(
            string owner,
            string repo,
            int issueNumber,

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.IssuesSetLabelsRequestVariant1, global::System.Collections.Generic.IList<string>, global::tryAGI.GitHub.IssuesSetLabelsRequestVariant3, global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssuesSetLabelsRequestVariant4Item>, string> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set labels for an issue<br/>
        /// Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Label>> IssuesSetLabelsAsync(
            string owner,
            string repo,
            int issueNumber,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}