#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// List Dependabot alerts for a repository<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="classification"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="manifest"></param>
        /// <param name="epssPercentage"></param>
        /// <param name="has"></param>
        /// <param name="assignee"></param>
        /// <param name="scope"></param>
        /// <param name="relationship"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlert>> DependabotListAlertsForRepoAsync(
            string owner,
            string repo,
            string? classification = default,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            string? manifest = default,
            string? epssPercentage = default,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotListAlertsForRepoHasVariant2Item>>? has = default,
            string? assignee = default,
            global::tryAGI.GitHub.DependabotListAlertsForRepoScope? scope = default,
            string? relationship = default,
            global::tryAGI.GitHub.DependabotListAlertsForRepoSort? sort = default,
            global::tryAGI.GitHub.DependabotListAlertsForRepoDirection? direction = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Dependabot alerts for a repository<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="classification"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="manifest"></param>
        /// <param name="epssPercentage"></param>
        /// <param name="has"></param>
        /// <param name="assignee"></param>
        /// <param name="scope"></param>
        /// <param name="relationship"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlert>>> DependabotListAlertsForRepoAsResponseAsync(
            string owner,
            string repo,
            string? classification = default,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            string? manifest = default,
            string? epssPercentage = default,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotListAlertsForRepoHasVariant2Item>>? has = default,
            string? assignee = default,
            global::tryAGI.GitHub.DependabotListAlertsForRepoScope? scope = default,
            string? relationship = default,
            global::tryAGI.GitHub.DependabotListAlertsForRepoSort? sort = default,
            global::tryAGI.GitHub.DependabotListAlertsForRepoDirection? direction = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}