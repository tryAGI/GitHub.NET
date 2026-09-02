#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get a custom property for an organization<br/>
        /// Gets a custom property that is defined for an organization.<br/>
        /// Organization members can read these properties.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="customPropertyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CustomProperty> OrgsCustomPropertiesForReposGetOrganizationDefinitionAsync(
            string org,
            string customPropertyName,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a custom property for an organization<br/>
        /// Gets a custom property that is defined for an organization.<br/>
        /// Organization members can read these properties.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="customPropertyName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CustomProperty>> OrgsCustomPropertiesForReposGetOrganizationDefinitionAsResponseAsync(
            string org,
            string customPropertyName,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}