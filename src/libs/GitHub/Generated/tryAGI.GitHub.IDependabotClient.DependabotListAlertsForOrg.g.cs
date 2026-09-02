#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// List Dependabot alerts for an organization<br/>
        /// Lists Dependabot alerts for an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="classification"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="epssPercentage"></param>
        /// <param name="artifactRegistryUrl"></param>
        /// <param name="artifactRegistry"></param>
        /// <param name="has"></param>
        /// <param name="assignee"></param>
        /// <param name="runtimeRisk"></param>
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlertWithRepository>> DependabotListAlertsForOrgAsync(
            string org,
            string? classification = default,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            string? epssPercentage = default,
            string? artifactRegistryUrl = default,
            string? artifactRegistry = default,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotListAlertsForOrgHasVariant2Item>>? has = default,
            string? assignee = default,
            string? runtimeRisk = default,
            global::tryAGI.GitHub.DependabotListAlertsForOrgScope? scope = default,
            string? relationship = default,
            global::tryAGI.GitHub.DependabotListAlertsForOrgSort? sort = default,
            global::tryAGI.GitHub.DependabotListAlertsForOrgDirection? direction = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Dependabot alerts for an organization<br/>
        /// Lists Dependabot alerts for an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="classification"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="epssPercentage"></param>
        /// <param name="artifactRegistryUrl"></param>
        /// <param name="artifactRegistry"></param>
        /// <param name="has"></param>
        /// <param name="assignee"></param>
        /// <param name="runtimeRisk"></param>
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
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlertWithRepository>>> DependabotListAlertsForOrgAsResponseAsync(
            string org,
            string? classification = default,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            string? epssPercentage = default,
            string? artifactRegistryUrl = default,
            string? artifactRegistry = default,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotListAlertsForOrgHasVariant2Item>>? has = default,
            string? assignee = default,
            string? runtimeRisk = default,
            global::tryAGI.GitHub.DependabotListAlertsForOrgScope? scope = default,
            string? relationship = default,
            global::tryAGI.GitHub.DependabotListAlertsForOrgSort? sort = default,
            global::tryAGI.GitHub.DependabotListAlertsForOrgDirection? direction = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}