#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICampaignsClient
    {
        /// <summary>
        /// List campaigns for an organization<br/>
        /// Lists campaigns in an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="state">
        /// Indicates whether a campaign is open or closed
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.CampaignSummary>> CampaignsListOrgCampaignsAsync(
            string org,
            int? page = default,
            int? perPage = default,
            global::tryAGI.GitHub.CampaignsListOrgCampaignsDirection? direction = default,
            global::tryAGI.GitHub.CampaignState? state = default,
            global::tryAGI.GitHub.CampaignsListOrgCampaignsSort? sort = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List campaigns for an organization<br/>
        /// Lists campaigns in an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="state">
        /// Indicates whether a campaign is open or closed
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.CampaignSummary>>> CampaignsListOrgCampaignsAsResponseAsync(
            string org,
            int? page = default,
            int? perPage = default,
            global::tryAGI.GitHub.CampaignsListOrgCampaignsDirection? direction = default,
            global::tryAGI.GitHub.CampaignState? state = default,
            global::tryAGI.GitHub.CampaignsListOrgCampaignsSort? sort = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}