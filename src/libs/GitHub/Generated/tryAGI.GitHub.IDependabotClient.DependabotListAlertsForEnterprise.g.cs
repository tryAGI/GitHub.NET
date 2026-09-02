#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// List Dependabot alerts for an enterprise<br/>
        /// Lists Dependabot alerts for repositories that are owned by the specified enterprise.<br/>
        /// The authenticated user must be a member of the enterprise to use this endpoint.<br/>
        /// Alerts are only returned for organizations in the enterprise for which you are an organization owner or a security manager. For more information about security managers, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="classification"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlertWithRepository>> DependabotListAlertsForEnterpriseAsync(
            string enterprise,
            string? classification = default,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            string? epssPercentage = default,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotListAlertsForEnterpriseHasVariant2Item>>? has = default,
            string? assignee = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseScope? scope = default,
            string? relationship = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseSort? sort = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseDirection? direction = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Dependabot alerts for an enterprise<br/>
        /// Lists Dependabot alerts for repositories that are owned by the specified enterprise.<br/>
        /// The authenticated user must be a member of the enterprise to use this endpoint.<br/>
        /// Alerts are only returned for organizations in the enterprise for which you are an organization owner or a security manager. For more information about security managers, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="classification"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
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
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotAlertWithRepository>>> DependabotListAlertsForEnterpriseAsResponseAsync(
            string enterprise,
            string? classification = default,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            string? epssPercentage = default,
            global::tryAGI.GitHub.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.GitHub.DependabotListAlertsForEnterpriseHasVariant2Item>>? has = default,
            string? assignee = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseScope? scope = default,
            string? relationship = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseSort? sort = default,
            global::tryAGI.GitHub.DependabotListAlertsForEnterpriseDirection? direction = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}