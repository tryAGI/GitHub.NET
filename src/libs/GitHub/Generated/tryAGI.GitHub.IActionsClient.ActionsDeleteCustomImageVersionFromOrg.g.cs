#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Delete an image version of custom image from the organization<br/>
        /// Delete an image version of custom image from the organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="imageDefinitionId"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsDeleteCustomImageVersionFromOrgAsync(
            string org,
            int imageDefinitionId,
            string version,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an image version of custom image from the organization<br/>
        /// Delete an image version of custom image from the organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="imageDefinitionId"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> ActionsDeleteCustomImageVersionFromOrgAsResponseAsync(
            string org,
            int imageDefinitionId,
            string version,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}