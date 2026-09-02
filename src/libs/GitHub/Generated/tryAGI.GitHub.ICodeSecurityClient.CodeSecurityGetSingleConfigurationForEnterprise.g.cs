#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Retrieve a code security configuration of an enterprise<br/>
        /// Gets a code security configuration available in an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeSecurityConfiguration> CodeSecurityGetSingleConfigurationForEnterpriseAsync(
            string enterprise,
            int configurationId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a code security configuration of an enterprise<br/>
        /// Gets a code security configuration available in an enterprise.<br/>
        /// The authenticated user must be an administrator of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CodeSecurityConfiguration>> CodeSecurityGetSingleConfigurationForEnterpriseAsResponseAsync(
            string enterprise,
            int configurationId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}