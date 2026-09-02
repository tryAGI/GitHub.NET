#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List image versions of a custom image for an organization<br/>
        /// List image versions of a custom image for an organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="imageDefinitionId"></param>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsListCustomImageVersionsForOrgResponse> ActionsListCustomImageVersionsForOrgAsync(
            int imageDefinitionId,
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List image versions of a custom image for an organization<br/>
        /// List image versions of a custom image for an organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="imageDefinitionId"></param>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsListCustomImageVersionsForOrgResponse>> ActionsListCustomImageVersionsForOrgAsResponseAsync(
            int imageDefinitionId,
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}