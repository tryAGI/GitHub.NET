#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// List issue suggestions<br/>
        /// Lists the suggestions on an issue. A suggestion is an agent-proposed change to an issue's type, labels, fields, assignees, or closed state that a maintainer can approve or dismiss.<br/>
        /// By default only pending suggestions are returned. Use `state=all` to return suggestions in every state, or `state=&lt;state&gt;` to filter to a single state. Use `action=&lt;action&gt;` to return only suggestions for a specific change.<br/>
        /// This endpoint is only available while the issue suggestions feature is enabled for the repository, and only supports issues, not pull requests.<br/>
        /// Requires triage access to the repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="state">
        /// Default Value: pending
        /// </param>
        /// <param name="action"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueSuggestion>> IssuesListSuggestionsAsync(
            string owner,
            string repo,
            int issueNumber,
            global::tryAGI.GitHub.IssuesListSuggestionsState? state = default,
            global::tryAGI.GitHub.IssuesListSuggestionsAction? action = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List issue suggestions<br/>
        /// Lists the suggestions on an issue. A suggestion is an agent-proposed change to an issue's type, labels, fields, assignees, or closed state that a maintainer can approve or dismiss.<br/>
        /// By default only pending suggestions are returned. Use `state=all` to return suggestions in every state, or `state=&lt;state&gt;` to filter to a single state. Use `action=&lt;action&gt;` to return only suggestions for a specific change.<br/>
        /// This endpoint is only available while the issue suggestions feature is enabled for the repository, and only supports issues, not pull requests.<br/>
        /// Requires triage access to the repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="state">
        /// Default Value: pending
        /// </param>
        /// <param name="action"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.IssueSuggestion>>> IssuesListSuggestionsAsResponseAsync(
            string owner,
            string repo,
            int issueNumber,
            global::tryAGI.GitHub.IssuesListSuggestionsState? state = default,
            global::tryAGI.GitHub.IssuesListSuggestionsAction? action = default,
            int? perPage = default,
            int? page = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}