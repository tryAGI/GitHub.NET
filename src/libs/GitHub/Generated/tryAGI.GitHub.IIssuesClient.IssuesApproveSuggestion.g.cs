#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Approve an issue suggestion<br/>
        /// Approves a pending suggestion on an issue. Applies the proposed change (creating the corresponding timeline event), transitions the suggestion to `approved`, and dismisses any competing pending suggestions for the same change.<br/>
        /// Requires triage access to the repository. Approving a suggestion also requires permission to perform the change it applies (for example, setting the issue type, adding a label or assignee, or closing the issue); this only affects fine-grained access tokens and GitHub Apps whose permissions are narrower than the triage role. This endpoint only supports issues, not pull requests.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="suggestionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.IssueSuggestion> IssuesApproveSuggestionAsync(
            string owner,
            string repo,
            int issueNumber,
            int suggestionId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Approve an issue suggestion<br/>
        /// Approves a pending suggestion on an issue. Applies the proposed change (creating the corresponding timeline event), transitions the suggestion to `approved`, and dismisses any competing pending suggestions for the same change.<br/>
        /// Requires triage access to the repository. Approving a suggestion also requires permission to perform the change it applies (for example, setting the issue type, adding a label or assignee, or closing the issue); this only affects fine-grained access tokens and GitHub Apps whose permissions are narrower than the triage role. This endpoint only supports issues, not pull requests.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="suggestionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.IssueSuggestion>> IssuesApproveSuggestionAsResponseAsync(
            string owner,
            string repo,
            int issueNumber,
            int suggestionId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}