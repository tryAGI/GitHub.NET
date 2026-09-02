#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Dismiss an issue suggestion<br/>
        /// Dismisses a pending suggestion on an issue. Transitions the suggestion to `dismissed` without applying any change or creating a timeline event.<br/>
        /// Requires triage access to the repository. This endpoint only supports issues, not pull requests.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="suggestionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.IssueSuggestion> IssuesDismissSuggestionAsync(
            string owner,
            string repo,
            int issueNumber,
            int suggestionId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dismiss an issue suggestion<br/>
        /// Dismisses a pending suggestion on an issue. Transitions the suggestion to `dismissed` without applying any change or creating a timeline event.<br/>
        /// Requires triage access to the repository. This endpoint only supports issues, not pull requests.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="suggestionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.IssueSuggestion>> IssuesDismissSuggestionAsResponseAsync(
            string owner,
            string repo,
            int issueNumber,
            int suggestionId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}