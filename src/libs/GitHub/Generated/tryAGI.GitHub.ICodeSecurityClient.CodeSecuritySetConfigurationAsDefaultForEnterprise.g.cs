#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ICodeSecurityClient
    {
        /// <summary>
        /// Set a code security configuration as a default for an enterprise<br/>
        /// Sets a code security configuration as a default to be applied to new repositories in your enterprise.<br/>
        /// This configuration will be applied by default to the matching repository type when created, but only for organizations within the enterprise that do not already have a default code security configuration set.<br/>
        /// The authenticated user must be an administrator for the enterprise to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponse> CodeSecuritySetConfigurationAsDefaultForEnterpriseAsync(
            string enterprise,
            int configurationId,

            global::tryAGI.GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a code security configuration as a default for an enterprise<br/>
        /// Sets a code security configuration as a default to be applied to new repositories in your enterprise.<br/>
        /// This configuration will be applied by default to the matching repository type when created, but only for organizations within the enterprise that do not already have a default code security configuration set.<br/>
        /// The authenticated user must be an administrator for the enterprise to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponse>> CodeSecuritySetConfigurationAsDefaultForEnterpriseAsResponseAsync(
            string enterprise,
            int configurationId,

            global::tryAGI.GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a code security configuration as a default for an enterprise<br/>
        /// Sets a code security configuration as a default to be applied to new repositories in your enterprise.<br/>
        /// This configuration will be applied by default to the matching repository type when created, but only for organizations within the enterprise that do not already have a default code security configuration set.<br/>
        /// The authenticated user must be an administrator for the enterprise to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="configurationId"></param>
        /// <param name="defaultForNewRepos">
        /// Specify which types of repository this security configuration should be applied to by default.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponse> CodeSecuritySetConfigurationAsDefaultForEnterpriseAsync(
            string enterprise,
            int configurationId,
            global::tryAGI.GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos? defaultForNewRepos = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}